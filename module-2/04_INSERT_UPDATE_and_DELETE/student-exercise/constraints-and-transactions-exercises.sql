-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
INSERT INTO actor (first_name, last_name)
VALUES ('Hampton', 'Avenue')

INSERT INTO actor (first_name, last_name)
VALUES ('Lisa', 'Byway')

SELECT *
FROM actor

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
SELECT *
FROM film

SELECT *
FROM language

INSERT INTO film (title, description, release_year, language_id, length)
VALUES ('Euclidean PI', 'The epic story of Euiclid as a pizza delivery boy in ancient Greece', 2008, 1, 198)

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
SELECT *
FROM film_actor
ORDER BY film_id DESC

SELECT *
FROM actor

INSERT INTO film_actor (actor_id, film_id)
VALUES (201, 1001)

INSERT INTO film_actor (actor_id, film_id)
VALUES (202, 1001)

-- 4. Add Mathmagical to the category table.
SELECT *
FROM category

INSERT INTO category (name)
VALUES ('Mathmagical')

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
SELECT *
FROM film_category
WHERE category_id = 17

UPDATE film_category 
SET category_id = 17
WHERE film_id IN (SELECT film_id
FROM film
WHERE title = 'Euclidean PI')

UPDATE film_category 
SET category_id = 17
WHERE film_id IN (SELECT film_id
FROM film
WHERE title = 'EGG IGBY')

UPDATE film_category 
SET category_id = 17
WHERE film_id IN (SELECT film_id
FROM film
WHERE title = 'KARATE MOON')

UPDATE film_category 
SET category_id = 17
WHERE film_id IN (SELECT film_id
FROM film
WHERE title = 'RANDOM GO')

UPDATE film_category 
SET category_id = 17
WHERE film_id IN (SELECT film_id
FROM film
WHERE title = 'YOUNG LANGUAGE')

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)
UPDATE film
SET rating = 'G'
WHERE film_id IN (SELECT film_id
FROM film_category
WHERE category_id = 17) 


SELECT *
FROM film
INNER JOIN film_category ON film.film_id = film_category.film_id
WHERE category_id = 17

-- 7. Add a copy of "Euclidean PI" to all the stores.
INSERT INTO inventory (film_id, store_id)
VALUES (1001, 1)

INSERT INTO inventory (film_id, store_id)
VALUES (1001, 2)

SELECT *
FROM store

SELECT * 
FROM inventory
WHERE film_id = 1001

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
SELECT *
FROM film
WHERE title = 'Euclidean PI'

DELETE
FROM film
WHERE title = 'Euclidean PI'
-- <YOUR ANSWER HERE>
-- The delete was unsuccessful because there is reference constraint of a foreign key on the film_id. 

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
SELECT *
FROM category
WHERE name = 'Mathmagical'

DELETE
FROM category
WHERE name = 'Mathmagical'

-- <YOUR ANSWER HERE>
--The delete was unsuccessful because there is a reference constraint of a foreign key on the category_id.

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
SELECT *
FROM film_category
WHERE category_id = 17; 

DELETE
FROM film_category
WHERE category_id = 17; 
-- <YOUR ANSWER HERE>
-- Delete was successful because we were able to remove the link to category id.

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
SELECT *
FROM category
WHERE name = 'Mathmagical'

DELETE
FROM category
WHERE name = 'Mathmagical'

SELECT *
FROM film
WHERE title = 'Euclidean PI'

DELETE
FROM film
WHERE title = 'Euclidean PI'
-- <YOUR ANSWER HERE>
--Was successful at deleting Mathmagical from the category table because we have removed the foreign key contraint.
-- Was not successful at deleting Euclidean PI because there is still a foreign key associated with film_actor table.

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.

--There is a check constraint on the film rating and default constraints on the film rental duration, the film rental rate, and the film replacement cost.
