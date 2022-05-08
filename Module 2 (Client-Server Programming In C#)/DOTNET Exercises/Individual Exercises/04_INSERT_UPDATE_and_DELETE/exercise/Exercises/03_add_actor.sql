-- 3. Did you know Eric Stoltz was originally cast as Marty McFly in "Back to the Future"? Add Eric Stoltz to the list of actors for "Back to the Future" (1 row)
--SELECT person_name FROM person p
--JOIN movie_actor ma ON p.person_id=ma.actor_id
--JOIN movie m ON ma.movie_id=m.movie_id
--WHERE m.title = 'Back to the Future' 

--INSERT INTO person (person_name) VALUES ((SELECT title FROM movie WHERE title = 'Back to the Future'),'Eric Stoltz') 

INSERT INTO movie_actor (movie_id,actor_id)
VALUES ((SELECT movie.movie_id FROM movie WHERE title = 'Back to the Future'), 
(SELECT person_id FROM person WHERE person_name = 'Eric Stoltz'))
