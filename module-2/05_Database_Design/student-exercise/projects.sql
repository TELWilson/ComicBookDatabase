CREATE DATABASE ProjectOrganizer

USE ProjectOrganizer

BEGIN TRANSACTION

CREATE TABLE EMPLOYEE (
employee_number int IDENTITY(1,1) PRIMARY KEY,
job_title varchar(50) NOT NULL,
last_name varchar(50) NOT NULL,
first_name varchar(50) NOT NULL,
gender char(1),
date_of_birth datetime,
date_of_hire datetime NOT NULL,
);

CREATE TABLE DEPARTMENT (
department_number int PRIMARY KEY NOT NULL,
department_name varchar(100) NOT NULL,
);

CREATE TABLE EMPLOYEE_DEPARTMENT (
employee_number int FOREIGN KEY REFERENCES EMPLOYEE(employee_number),
department_number int FOREIGN KEY REFERENCES DEPARTMENT(department_number),
CONSTRAINT PK_EMPLOYEE_DEPARTMENT PRIMARY KEY (employee_number, department_number),
);

CREATE TABLE PROJECT (
project_number int IDENTITY(1,1) PRIMARY KEY,
project_name varchar(100) NOT NULL,
start_date datetime NOT NULL,
);

CREATE TABLE EMPLOYEE_PROJECT (
project_number int FOREIGN KEY REFERENCES PROJECT(project_number),
employee_number int FOREIGN KEY REFERENCES EMPLOYEE(employee_number),
CONSTRAINT PK_EMPLOEE_PROJECT PRIMARY KEY (project_number, employee_number),
);

COMMIT TRANSACTION

--INSERT 4 PROJECTS
--Needs at least one employee each
INSERT INTO PROJECT (project_name, start_date)
VALUES ('EPIC Project', 07/03/2020)

UPDATE PROJECT
SET start_date = 2020-07-03
WHERE project_name = 'EPIC Project'

UPDATE PROJECT
SET start_date = '2020-07-03 00:00:00'
WHERE project_name = 'EPIC Project'

INSERT INTO EMPLOYEE_PROJECT (employee_number, project_number)
VALUES (1,1)

INSERT INTO PROJECT (project_name, start_date)
VALUES('.NET rocks', 09/14/2020)

UPDATE PROJECT
SET start_date = 2020-09-14
WHERE project_name = '.NET rocks'

UPDATE PROJECT
SET start_date = '2020-09-14 00:00:00'
WHERE project_name = '.NET rocks'

INSERT INTO EMPLOYEE_PROJECT (employee_number, project_number)
VALUES (2,2)

INSERT INTO PROJECT (project_name, start_date)
VALUES('Pigs can fly', 01/01/2020)

UPDATE PROJECT
SET start_date = 2020-01-01
WHERE project_name = 'Pigs can fly'

UPDATE PROJECT
SET start_date = '2020-01-01 00:00:00'
WHERE project_name = 'Pigs can fly'

INSERT INTO EMPLOYEE_PROJECT (employee_number, project_number)
VALUES (5,3)

INSERT INTO PROJECT (project_name, start_date)
VALUES('SQL is the best', 03/20/2020)

UPDATE PROJECT
SET start_date = 2020-03-20
WHERE project_name = 'SQL is the best'

UPDATE PROJECT
SET start_date = '2020-03-20 00:00:00'
WHERE project_name = 'SQL is the best'

INSERT INTO EMPLOYEE_PROJECT (employee_number, project_number)
VALUES (4,4)

SELECT *
FROM PROJECT

SELECT *
FROM EMPLOYEE_PROJECT

--INSERT 4 DEPARTMENTS
-- NEEDS at least two employees each

SELECT *
FROM DEPARTMENT

INSERT INTO DEPARTMENT (department_number, department_name)
VALUES (001, 'Accounting')

INSERT INTO EMPLOYEE_DEPARTMENT(department_number, employee_number)
VALUES (001, 1)

INSERT INTO EMPLOYEE_DEPARTMENT(department_number, employee_number)
VALUES (001, 2)

INSERT INTO DEPARTMENT (department_number, department_name)
VALUES (002, 'Databases')

INSERT INTO EMPLOYEE_DEPARTMENT(department_number, employee_number)
VALUES (002, 3)

INSERT INTO EMPLOYEE_DEPARTMENT(department_number, employee_number)
VALUES (002, 4)

INSERT INTO DEPARTMENT (department_number, department_name)
VALUES (003, 'Dragonslaying')

INSERT INTO EMPLOYEE_DEPARTMENT(department_number, employee_number)
VALUES (003, 5)

INSERT INTO EMPLOYEE_DEPARTMENT(department_number, employee_number)
VALUES (003, 6)

INSERT INTO DEPARTMENT (department_number, department_name)
VALUES (004, 'Marketing')

INSERT INTO EMPLOYEE_DEPARTMENT(department_number, employee_number)
VALUES (004, 7)

INSERT INTO EMPLOYEE_DEPARTMENT(department_number, employee_number)
VALUES (004, 8)

SELECT *
FROM EMPLOYEE_DEPARTMENT

--INSERT 8 EMPLOYEES
SELECT *
FROM EMPLOYEE


INSERT INTO EMPLOYEE (job_title, last_name, first_name, gender, date_of_hire)
VALUES ('Accountant', 'Williams', 'Andrew', 'M', 2000-02-01)

UPDATE EMPLOYEE
SET date_of_hire = '2000-02-01 00:00:00'
WHERE employee_number = 1

INSERT INTO EMPLOYEE (job_title, last_name, first_name, gender, date_of_hire)
VALUES ('Number Wizard', 'Kronger', 'Shelby', 'F', 2017-05-05)

UPDATE EMPLOYEE
SET date_of_hire = '2017-05-05 00:00:00'
WHERE employee_number = 2

INSERT INTO EMPLOYEE (job_title, last_name, first_name, gender, date_of_hire)
VALUES ('DBA', 'Normandy', 'Michele', 'M', 2015-06-06)

UPDATE EMPLOYEE
SET date_of_hire = '2015-06-06 00:00:00'
WHERE employee_number = 3

INSERT INTO EMPLOYEE (job_title, last_name, first_name, gender, date_of_hire)
VALUES ('Data Master', 'Berlin', 'Jens', 'F', 1992-07-07)

UPDATE EMPLOYEE
SET date_of_hire = '1992-07-07 00:00:00'
WHERE employee_number = 4

INSERT INTO EMPLOYEE (job_title, last_name, first_name, gender, date_of_hire)
VALUES ('Dragon Charmer', 'Wizard', 'Merlyn', 'F', 2018-08-08)

UPDATE EMPLOYEE
SET date_of_hire = '2018-08-08 00:00:00'
WHERE employee_number = 5

INSERT INTO EMPLOYEE (job_title, last_name, first_name, gender, date_of_hire)
VALUES ('Master of Hunting', 'Meister', 'Jaeger', 'M', 2018-09-09)

UPDATE EMPLOYEE
SET date_of_hire = '2018-09-09 00:00:00'
WHERE employee_number = 6

INSERT INTO EMPLOYEE (job_title, last_name, first_name, gender, date_of_hire)
VALUES ('CMO', 'Results', 'Julie', 'F', 2006-10-10)

UPDATE EMPLOYEE
SET date_of_hire = '2006-10-10 00:00:00'
WHERE employee_number = 7

INSERT INTO EMPLOYEE (job_title, last_name, first_name, gender, date_of_hire)
VALUES ('Director of Marketing', 'Bridge', 'London', 'M', 2009-11-11)

UPDATE EMPLOYEE
SET date_of_hire = '2009-11-11 00:00:00'
WHERE employee_number = 8
