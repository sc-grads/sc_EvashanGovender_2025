SELECT A.EmployeeNumber, A.AttendanceMonth, 
A.NumberAttendance, 
first_value(NumberAttendance)
OVER(partition by E.EmployeeNumber order by A.AttendanceMonth) as FirstMonth,
last_value(NumberAttendance)
OVER(partition by E.EmployeeNumber order by A.AttendanceMonth
ROWS between unbounded preceding and unbounded following) as LastMonth
FROM tblEmployee as E join tblAttendance as A
ON E.EmployeeNumber = A.EmployeeNumber
