with tblWithRanking as
(select D.Department, EmployeeNumber, EmployeeFirstName, EmployeeLastName,
       rank() over(partition by D.Department order by E.EmployeeNumber) as TheRank
 from tblDepartment as D 
 join tblEmployee as E on D.Department = E.Department)

select * from tblWithRanking 
where TheRank <= 5
order by Department, EmployeeNumber
