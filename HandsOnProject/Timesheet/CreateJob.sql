USE [msdb]
GO
DECLARE @jobId BINARY(16)
EXEC  msdb.dbo.sp_add_job @job_name=N'Execute_SSIS_Package_Job', 
		@enabled=1, 
		@notify_level_eventlog=0, 
		@notify_level_email=2, 
		@notify_level_page=2, 
		@delete_level=0, 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'Sambe2025002\EvashenGovender', @job_id = @jobId OUTPUT
select @jobId
GO
EXEC msdb.dbo.sp_add_jobserver @job_name=N'Execute_SSIS_Package_Job', @server_name = N'SAMBE2025002\MSSQLSERVER2'
GO
USE [msdb]
GO
EXEC msdb.dbo.sp_add_jobstep @job_name=N'Execute_SSIS_Package_Job', @step_name=N'Step1', 
		@step_id=1, 
		@cmdexec_success_code=0, 
		@on_success_action=3, 
		@on_fail_action=2, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'SSIS', 
		@command=N'/ISSERVER "\"\SSISDB\SSISMigrationProject\SSISProjectTrial\Package.dtsx\"" /SERVER "\".\"" /Par "\"$ServerOption::LOGGING_LEVEL(Int16)\"";1 /Par "\"$ServerOption::SYNCHRONIZED(Boolean)\"";True /CALLERINFO SQLAGENT /REPORTING E', 
		@database_name=N'master', 
		@flags=0
GO
USE [msdb]
GO
EXEC msdb.dbo.sp_add_jobstep @job_name=N'Execute_SSIS_Package_Job', @step_name=N'Step 2', 
		@step_id=2, 
		@cmdexec_success_code=0, 
		@on_success_action=1, 
		@on_fail_action=2, 
		@retry_attempts=0, 
		@retry_interval=0, 
		@os_run_priority=0, @subsystem=N'PowerShell', 
		@command=N'# Set the path to your Elasticsearch executable
$elasticPath ="C:\ELK\elasticsearch-9.0.2\bin\elasticsearch.bat"
 
# Launch Elasticsearch
Start-Process -FilePath $elasticPath
 
Start-Sleep -Seconds 60
 
# Set the path to your Logstash installation and config file
$logstashPath = "C:\ELK\logstash-9.0.2\bin\logstash.bat"
$configFile = "C:\ELK\data\sql_server_auditLog_migration.conf"
 
# Run Logstash with your configuration file
Start-Process -FilePath $logstashPath -ArgumentList "-f `"$configFile`"" -NoNewWindow -Wait
 
# Set the path to your Logstash installation and config file
$logstashPath = "C:\ELK\logstash-9.0.2\bin\logstash.bat"
$ErrconfigFile = "C:\ELK\data\sql_server_errorLog_migration.conf"
 
# Run Logstash with your configuration file
Start-Process -FilePath $logstashPath -ArgumentList "-f `"$ErrconfigFile`"" -NoNewWindow -Wait', 
		@database_name=N'master', 
		@flags=0
GO
USE [msdb]
GO
EXEC msdb.dbo.sp_update_job @job_name=N'Execute_SSIS_Package_Job', 
		@enabled=1, 
		@start_step_id=1, 
		@notify_level_eventlog=0, 
		@notify_level_email=2, 
		@notify_level_page=2, 
		@delete_level=0, 
		@description=N'', 
		@category_name=N'[Uncategorized (Local)]', 
		@owner_login_name=N'Sambe2025002\EvashenGovender', 
		@notify_email_operator_name=N'', 
		@notify_page_operator_name=N''
GO
