-- 12. Create a "Bill Murray Collection" in the collection table. 
-- For the movies that have Bill Murray in them, set their collection ID to the "Bill Murray Collection". (1 row, 6 rows)

INSERT INTO collection (collection_name)
VALUES ('Bill Murray Collection')

UPDATE movie SET movie.collection_ID = 
(SELECT c.collection_id FROM collection c WHERE c.collection_name = 'Bill Murray Collection')

WHERE movie_id IN (SELECT ma.movie_id FROM movie_actor ma WHERE actor_id =
(SELECT p.person_id FROM person p WHERE person_name = 'Bill Murray'))



-- UPDATE movie_actor SET movie_id = (SELECT m.movie_id FROM movie m WHERE m.collection_id = '895483')
-- UPDATE person SET person_id = 
-- UPDATE movie_actor SET actor_id = (SELECT person_id FROM person WHERE person_name = 'Bill Murray')
-- UPDATE movie_actor SET actor_id = (SELECT m.movie_id FROM movie m WHERE collection_id = (SELECT c.collection_id FROM collection c WHERE c.collection_name = 'Bill Murray Collection')
-- UPDATE movie_actor SET movie_actor.movie_id = (SELECT m.movie_id FROM movie m WHERE m.collection_id = (SELECT c.collection_id FROM collection c WHERE c.collection_name = 'Bill Murray Collection'))
-- UPDATE person SET person_id = (SELECT actor_id  FROM movie_actor ma WHERE (SELECT person_name FROM person WHERE person_name = 'Bill Murray')
