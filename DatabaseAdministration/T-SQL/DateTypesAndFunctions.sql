Select CURRENT_TIMESTAMP as RightNow
Select GETDATE() as RightNow
Select SYSDATETIME() as RightNow

Select DATEADD(YEAR,1,'2015-01-02 03:04:05') as myYear
Select DATEPART(HOUR,'2015-01-02 03:04:05' ) as myHour
Select DATENAME(WEEKDAY,getdate()) as myAnswer
Select DATEDIFF(MONTH,'2015-01-02 03:04:05',GETDATE()) as SecondsElapsed