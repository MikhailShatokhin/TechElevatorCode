-- 3. For all actors with the last name of "Jones", display the actor's name and movie titles they appeared in. Order the results by the actor names (A-Z). (48 rows)
SELECT p.person_name, m.title FROM person p
JOIN movie_actor ma ON ma.actor_id=p.person_id
JOIN movie m ON m.movie_id=ma.movie_id
WHERE person_name like '% jones'
ORDER BY p.person_name;

