-- 21. The census region, and the average, minimum, and maximum population of states and districts in each census region. Exclude ones that don't have a census region.
-- Name the population columns 'average_population, 'min_population', and 'max_population'.
-- Order the results from lowest to highest average population.
-- (4 rows)
SELECT census_region, AVG(population) average_population, MIN(population) min_population, MAX(population) max_population FROM state
WHERE census_region is not null
GROUP BY census_region
ORDER BY average_population;
