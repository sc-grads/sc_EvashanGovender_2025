select E.Department, E.EmployeeNumber, A.AttendanceMonth as AttendanceMonth, sum(A.NumberAttendance) as NumberAttendance,
GROUPING(E.EmployeeNumber) AS EmployeeNumberGroupedBy,
GROUPING_ID(E.Department, E.EmployeeNumber, A.AttendanceMonth) AS EmployeeNumberGroupedID
from tblEmployee as E join tblAttendance as A
on E.EmployeeNumber = A.EmployeeNumber
group by GROUPING SETS ((E.Department, E.EmployeeNumber, A.AttendanceMonth), (E.Department), ())
order by coalesce(Department, 'zzzzzzz'), coalesce(E.EmployeeNumber, 99999), coalesce(AttendanceMonth,'2100-01-01')
