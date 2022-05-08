-- 7. Remove the actor appearances in "Avengers: Infinity War" (14 rows)
-- Note: Don't remove the actors themeselves, just make it so it seems no one appeared in the movie.
--SELECT person_name FROM person p
--JOIN movie_actor ma ON p.person_id=ma.actor_id
--JOIN movie m ON ma.movie_id=m.movie_id
--WHERE m.title = 'Avengers: Infinity War'

DELETE FROM movie_actor
WHERE movie_id = (SELECT movie_id FROM movie WHERE title = 'Avengers: Infinity War')



