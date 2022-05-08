-- 12. The titles of the movies in the "Star Wars Collection" that weren't directed by George Lucas (5 rows)
SELECT m.title FROM person p
JOIN movie m ON m.director_id=p.person_id
JOIN collection c ON c.collection_id=m.collection_id
WHERE p.person_name != 'George Lucas' AND c.collection_name = 'Star Wars Collection'
