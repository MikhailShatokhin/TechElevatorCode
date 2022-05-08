-- 4. Add a "Sports" genre to the genre table. Add the movie "Coach Carter" to the newly created genre. (1 row each)
--INSERT INTO genre (genre_name) Values('Sports')
--INSERT INTO movie (title) VALUES('Coach Carter')

--INSERT INTO movie_genre (movie_id,genre_id)
--VALUES ((SELECT movie.movie_id FROM movie WHERE title = 'Back to the Future'), 
--(SELECT person_id FROM person WHERE person_name = 'Eric Stoltz'))

INSERT INTO genre (genre_name) Values('Sports')
INSERT INTO movie_genre (movie_id, genre_id)
	VALUES(
	(SELECT movie.movie_id FROM movie WHERE title = 'Coach Carter'),
	(SELECT genre.genre_id FROM genre WHERE genre_name = 'Sports'))
