SELECT 
	*
FROM movies 
WHERE id = 6;

SELECT 
	*
FROM movies
WHERE [year] BETWEEN 2000 AND 2010;

SELECT 
	*
FROM movies
WHERE [year] < 2000 OR [year] > 2010;

SELECT 
	*
FROM movies
WHERE year <= 2003;