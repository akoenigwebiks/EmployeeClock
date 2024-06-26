SELECT * FROM Employees INNER JOIN Passwords 
	ON Employees.code = Passwords.employee_code 
	WHERE Employees.id = '200024398' 
	AND passwords.password = '12345'