-- https://www.hackerrank.com/challenges/earnings-of-employees/problem?isFullScreen=true
SELECT (MONTHS*SALARY) AS EARNINGS, COUNT(*) FROM employee
GROUP BY EARNINGS
ORDER BY EARNINGS DESC
LIMIT 1;