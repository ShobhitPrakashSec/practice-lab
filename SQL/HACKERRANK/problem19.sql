-- https://www.hackerrank.com/challenges/salary-of-employees/problem?isFullScreen=true
SELECT NAME FROM employee
WHERE salary > 2000 AND MONTHS < 10
ORDER BY employee_ID;