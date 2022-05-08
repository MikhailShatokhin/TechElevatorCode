-- 16. The names and birthdays of actors born in the 1950s who acted in movies that were released in 1985 (20 rows)
SELECT DISTINCT p.person_name, p.birthday FROM person p
JOIN movie_actor ma ON ma.actor_id=p.person_id
JOIN movie m ON m.movie_id=ma.movie_id
WHERE m.release_date like '1985%' AND p.birthday like '195%'
