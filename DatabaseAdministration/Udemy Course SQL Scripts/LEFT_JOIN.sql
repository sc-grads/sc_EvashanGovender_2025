Select s.RollNo,s.StudentName,c.CourseID FROM Student s 
LEFT JOIN Course c ON s.RollNO = c.RollNO
