-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT *
FROM film AS f
INNER JOIN film_actor AS fa ON f.film_id = fa.film_id
INNER JOIN actor AS a ON fa.actor_id = a.actor_id
WHERE a.first_name = 'Nick'
AND a.last_name = 'Stallone';


-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT *
FROM film AS f
INNER JOIN film_actor AS fa ON f.film_id = fa.film_id
INNER JOIN actor AS a ON fa.actor_id = a.actor_id
WHERE a.first_name = 'Rita'
AND a.last_name = 'Reynolds';

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT *
FROM film AS f
INNER JOIN film_actor AS fa ON f.film_id = fa.film_id
INNER JOIN actor AS a ON fa.actor_id = a.actor_id
WHERE a.first_name = 'Judy'
OR a.first_name = 'River'
AND a.last_name = 'Dean';

-- 4. All of the the ‘Documentary’ films
-- (68 rows)
Select *
FROM film AS f
INNER JOIN film_category AS fc ON f.film_id = fc.film_id
INNER JOIN category AS c ON fc.category_id = c.category_id
WHERE c.name = 'Documentary';


-- 5. All of the ‘Comedy’ films
-- (58 rows)
Select *
FROM film AS f
INNER JOIN film_category AS fc ON f.film_id = fc.film_id
INNER JOIN category AS c ON fc.category_id = c.category_id
WHERE c.name = 'Comedy';

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
Select *
FROM film AS f
INNER JOIN film_category AS fc ON f.film_id = fc.film_id
INNER JOIN category AS c ON fc.category_id = c.category_id
WHERE c.name = 'Children'
AND f.rating = 'G';

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
Select *
FROM film AS f
INNER JOIN film_category AS fc ON f.film_id = fc.film_id
INNER JOIN category AS c ON fc.category_id = c.category_id
WHERE c.name = 'Family'
AND f.rating = 'G'
AND f.length < 120;

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT *
FROM film AS f
INNER JOIN film_actor AS fa ON f.film_id = fa.film_id
INNER JOIN actor AS a ON fa.actor_id = a.actor_id
WHERE a.first_name = 'Matthew'
AND a.last_name = 'Leigh'
AND f.rating = 'G';

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
Select *
FROM film AS f
INNER JOIN film_category AS fc ON f.film_id = fc.film_id
INNER JOIN category AS c ON fc.category_id = c.category_id
WHERE c.name = 'Sci-Fi'
AND f.release_year = 2006;

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT *
FROM film AS f
INNER JOIN film_actor AS fa ON f.film_id = fa.film_id
INNER JOIN actor AS a ON fa.actor_id = a.actor_id
INNER JOIN film_category AS fc ON fc.film_id = f.film_id
INNER JOIN category AS c ON fc.category_id = c.category_id
WHERE a.first_name = 'Nick'
AND a.last_name = 'Stallone'
AND c.name = 'Action';

-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
SELECT a.address AS streetAddress, ci.city, a.district, co.country
FROM address AS a
INNER JOIN store AS s ON a.address_id = s.address_id
INNER JOIN city AS ci ON a.city_id = ci.city_id
INNER JOIN country AS co ON ci.country_id = co.country_id;

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)


SELECT s.store_id, a.address AS streetAddress, staff.first_name + ' ' + staff.last_name AS managerName
FROM address AS a
INNER JOIN store AS s ON a.address_id = s.address_id
INNER JOIN staff ON staff.staff_id = s.manager_staff_id

-- 13. The first and last name of the top ten customers ranked by number of rentals 
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)
SELECT TOP (10) COUNT(r.customer_id) AS numRentals, c.first_name + ' ' + c.last_name AS custName
FROM rental AS r
INNER JOIN customer AS c ON r.customer_id = c.customer_id
GROUP BY c.customer_id, c.first_name, c.last_name
ORDER BY numRentals DESC


-- 14. The first and last name of the top ten customers ranked by dollars spent 
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)
SELECT TOP (10) SUM(p.amount) AS spent, c.first_name + ' ' + c.last_name AS custName
FROM customer AS c
INNER JOIN payment AS p ON c.customer_id = p.customer_id
GROUP BY c.customer_id, c.first_name, c.last_name
ORDER BY spent DESC


-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that an employee may work at multiple stores.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)
SELECT s.store_id, a.address, COUNT(i.inventory_id) AS totalRentals, SUM(p.amount) AS totalSales, AVG (p.amount) AS avgSale
FROM store AS s
INNER JOIN address AS a ON s.address_id = a.address_id
INNER JOIN inventory AS i ON s.store_id = i.store_id
INNER JOIN rental AS r ON r.inventory_id = i.inventory_id
INNER JOIN payment AS p ON r.rental_id = p.rental_id
GROUP BY a.address, s.store_id



-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
SELECT TOP (10) f.title, COUNT(i.inventory_id) AS numRentals
FROM inventory AS i
INNER JOIN film AS f ON i.film_id = f.film_id
INNER JOIN rental AS r ON i.inventory_id = r.inventory_id
GROUP BY i.film_id, f.title
ORDER BY numRentals DESC;


-- 17. The top five film categories by number of rentals 
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)
SELECT TOP (5) c.name AS catName, COUNT(r.inventory_id) AS numRentals
FROM inventory AS i
INNER JOIN rental AS r ON i.inventory_id = r.inventory_id
INNER JOIN film AS f ON i.film_id = f.film_id
INNER JOIN film_category AS fc on f.film_id = fc.film_id
INNER JOIN category AS c ON c.category_id = fc.category_id
GROUP BY c.name
ORDER BY numRentals DESC;

-- 18. The top five Action film titles by number of rentals 
-- (#1 should have 30 rentals and #5 should have 28 rentals)
SELECT TOP (5) f.title, COUNT(r.inventory_id) AS numRentals
FROM inventory AS i
INNER JOIN rental AS r ON i.inventory_id = r.inventory_id
INNER JOIN film AS f ON i.film_id = f.film_id
INNER JOIN film_category AS fc on f.film_id = fc.film_id
INNER JOIN category AS c ON c.category_id = fc.category_id
WHERE c.name = 'Action'
GROUP BY f.title
ORDER BY numRentals DESC;

-- 19. The top 10 actors ranked by number of rentals of films starring that actor 
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)
SELECT TOP (10) a.first_name + ' ' + a.last_name AS actName, COUNT(r.inventory_id) AS numRentals
FROM actor AS a
INNER JOIN film_actor AS fa ON a.actor_id = fa.actor_id
INNER JOIN film AS f ON f.film_id = fa.film_id
INNER JOIN inventory AS i ON  i.film_id = f.film_id
INNER JOIN rental AS r ON r.inventory_id = i.inventory_id
GROUP BY a.actor_id, a.first_name, a.last_name
ORDER BY numRentals DESC

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor 
-- (#1 should have 87 rentals and #5 should have 72 rentals)
SELECT TOP (5) a.first_name + ' ' + a.last_name AS actName, COUNT(r.inventory_id) AS numRentals
FROM inventory AS i
INNER JOIN rental AS r ON i.inventory_id = r.inventory_id
INNER JOIN film AS f ON i.film_id = f.film_id
INNER JOIN film_category AS fc on f.film_id = fc.film_id
INNER JOIN category AS c ON c.category_id = fc.category_id
INNER JOIN film_actor AS fa ON fa.film_id = f.film_id
INNER JOIN actor AS a ON a.actor_id = fa.actor_id
WHERE c.name = 'Comedy'
GROUP BY a.first_name, a.last_name
ORDER BY numRentals DESC;
