-- Create folder if not exists
IF NOT EXISTS (SELECT 1 FROM SSISDB.catalog.folders WHERE name = 'SSISMigrationProject')
BEGIN
  EXEC SSISDB.catalog.create_folder @folder_name = 'SSISMigrationProject', @folder_id = NULL
END

-- Deploy the package
DECLARE @ProjectBinary VARBINARY(MAX)
SELECT @ProjectBinary = BulkColumn 
FROM OPENROWSET(BULK '$(IspacPath)', SINGLE_BLOB) AS x

EXEC SSISDB.catalog.deploy_project 
  @folder_name = 'SSISMigrationProject',
  @project_name = 'TimesheetMigration',
  @project_stream = @ProjectBinary