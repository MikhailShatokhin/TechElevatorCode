-- 8. Remove "Penn Jillette" from the person table 
-- You'll have to remove data from another table before you can make him "disappear" (Get it? Because he's a magician...) (1 row each)

DELETE from movie_actor
WHERE actor_id = (SELECT person_id FROM person WHERE person_name = 'Penn Jillette')
DELETE from person
WHERE person_name = 'Penn Jillete'
DELETE from person
WHERE person_id = (SELECT person_id FROM person WHERE person_name = 'Penn Jillette')