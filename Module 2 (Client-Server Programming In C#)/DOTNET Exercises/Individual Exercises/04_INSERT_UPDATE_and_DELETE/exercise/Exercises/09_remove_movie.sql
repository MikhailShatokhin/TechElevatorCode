-- 9. Remove "Memento" from the movie table
-- You'll have to remove data from two other tables before you can remove it (13 rows, 2 rows, 1 row)
DELETE movie_actor
WHERE movie_actor.movie_id = (SELECT movie.movie_id FROM movie WHERE movie.title = 'Memento')

DELETE movie_genre
WHERE movie_genre.movie_id = (SELECT movie.movie_id FROM movie WHERE movie.title = 'Memento')

DELETE movie
WHERE movie.movie_id = (SELECT movie.movie_id FROM movie WHERE movie.title = 'Memento')
DELETE movie
WHERE movie.title = 'Memento'
