SELECT e.id, s.*
FROM Employees e
INNER JOIN Shifts s ON e.code = s.employee_code
INNER JOIN (
    SELECT employee_code, MAX(entry_time) AS MaxEntryTime
    FROM Shifts
    GROUP BY employee_code
) ms ON s.employee_code = ms.employee_code AND s.entry_time = ms.MaxEntryTime
WHERE e.id = 200024398;