USE [msdb]
GO

-- 1. Create the job
DECLARE @jobId BINARY(16)
EXEC msdb.dbo.sp_add_job
    @job_name = N'Execute_SSIS_Package_Job',
    @enabled = 1,
    @owner_login_name = N'Sambe2025002\EvashenGovender', -- Change to appropriate login
    @job_id = @jobId OUTPUT

-- 2. Add job step to execute the SSIS package
EXEC msdb.dbo.sp_add_jobstep
    @job_name = N'Execute_SSIS_Package_Job',
    @step_name = N'Run SSIS Package',
    @subsystem = N'SSIS',
    @command = N'/FILE "\Integration Services Catalogs/SSISDB/SSISMigration/Project/Projects/SSISProjectTrial/Packages/Packages.dtsx" /CHECKPOINTING OFF /REPORTING E',
    @database_name = N'master'

