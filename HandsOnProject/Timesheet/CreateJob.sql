USE [msdb]
GO

-- 1. Create the job
IF EXISTS (SELECT job_id FROM msdb.dbo.sysjobs WHERE name = N'Execute_SSIS_Package_Job')
BEGIN
    EXEC msdb.dbo.sp_delete_job @job_name = N'Execute_SSIS_Package_Job', @delete_unused_schedule = 1;
END
GO

DECLARE @jobId BINARY(16)
EXEC msdb.dbo.sp_add_job
    @job_name = N'Execute_SSIS_Package_Job',
    @enabled = 1,
    @owner_login_name = N'sa', -- Change to appropriate login
    @job_id = @jobId OUTPUT

-- 2. Add job step to execute the SSIS package
EXEC msdb.dbo.sp_add_jobstep
    @job_name = N'Execute_SSIS_Package_Job',
    @step_name = N'Run SSIS Package',
    @subsystem = N'SSIS',
    @command = N'/FILE "\Integration Services Catalogs/SSISDB/SSISMigration/Projects/SSISProjectTrial/Packages/Packages.dtsx" /CHECKPOINTING OFF /REPORTING E',
    @database_name = N'master'

 
-- Assign the job to the target server
EXEC msdb.dbo.sp_add_jobserver
    @job_id = @jobId,
    @server_name = N'(local)'; -- Adjust if targeting a remote server
GO