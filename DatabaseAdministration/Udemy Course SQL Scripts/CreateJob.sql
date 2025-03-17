USE [msdb]
GO
EXEC msdb.dbo.sp_update_job @job_id=N'eaec9483-535c-4c10-aafc-351e9a933b16', 
		@notify_level_email=2, 
		@notify_level_page=2
GO
USE [msdb]
GO
EXEC msdb.dbo.sp_update_jobstep @job_id=N'eaec9483-535c-4c10-aafc-351e9a933b16', @step_id=1 , 
		@database_name=N'PracticeDB'
GO
USE [msdb]
GO
DECLARE @schedule_id int
EXEC msdb.dbo.sp_add_jobschedule @job_id=N'eaec9483-535c-4c10-aafc-351e9a933b16', @name=N'Daily @ 10pm', 
		@enabled=1, 
		@freq_type=8, 
		@freq_interval=62, 
		@freq_subday_type=1, 
		@freq_subday_interval=0, 
		@freq_relative_interval=0, 
		@freq_recurrence_factor=1, 
		@active_start_date=20250317, 
		@active_end_date=20250320, 
		@active_start_time=220000, 
		@active_end_time=235959, @schedule_id = @schedule_id OUTPUT
select @schedule_id
GO
