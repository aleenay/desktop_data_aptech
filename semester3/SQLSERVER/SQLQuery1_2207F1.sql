create database db_batch2207F1;
use db_batch2207F1;
create table tbl_stds(
id int,
name varchar(100),
age int ,
city varchar(100)

);

Alter table tbl_stds ADD email varchar(100);
ALTER TABLE tbl_stds DROP COLUMN age;

CREATE TABLE Persons (
    ID int NOT NULL PRIMARY KEY identity(1,1), /* identity(10,5) */
    LastName varchar (255) NOT NULL,
    FirstName varchar (255) NOT NULL,
    Age int check(Age > 18),
	city varchar(100) default 'khi',
	email varchar(100) not null unique
);
Truncate table Persons
Drop table Persons;

INSERT INTO Persons ( FirstName,LastName, age,city,email) VALUES ('Ayan','ahmed',29,'hyd','ayan@gmail.com'),
('Abbas','Khan',19,'hyd','abbas@gmail.com'),('tooba','Khan',45,'islamabad','maham@gmail.com'),
('wajahat','Khan',27,'lahore','wajaht@gmail.com'),('Aliya','Khan',25,'hyd','aliyakhan75@gmail.com'),
('Muhammad','mursaleen',22,'lahore','mm@gmail.com'),('moeez','Khan',25,'hyd','m3423@gmail.com'),
('dania','siddiqui',20,'lahore','ds@gmail.com'),('tooba','Khan',28,'islamabad','tooba12@gmail.com'),
('Aliya','Khan',21,'hyd','ali344@gmail.com'),('Aliya','Khan',30,'islamabad','aliya4534563@gmail.com'),
('Aliya','Khan',28,'hyd','al34@gmail.com'),('Aliya','Khan',31,'hyd','aliya7675@gmail.com'),
('Abbas','Khan',25,'lahore','a123@gmail.com'),('tooba','Khan',19,'islamabad','tk123@gmail.com'),
('iqra','Khan',40,'lahore','iqra@gmail.com'),('Aliza','ahmed',19,'islamabad','aliza@gmail.com'),
('muhammad','rameez',25,'lahore','mr@gmail.com'),('Ali','Khan',19,'hyd','ali423@gmail.com'),
('Abbas','Khan',33,'hyd','akk@gmail.com'),('tooba','Khan',19,'hyd','ali000@gmail.com'),
('warda','ahmed',33,'karachi','waa@gmail.com'),('Aliyan','Khan',19,'islamabad','aliyan@gmail.com'),
('Aliya','Khan',25,'hyd','ak@gmail.com'),('ali','raza',19,'islamabad','aliraza@gmail.com'),
('warda','ahmed',26,'karachi','w@gmail.com'),('Aliya','Khan',20,'hyd','ali56@gmail.com'),
('warda','ahmed',26,'lahore','wa@gmail.com'),('Aliya','Khan',20,'islamabad','ali755@gmail.com');



select * from Persons ORDER BY FirstName ASC;
select FirstName ,Age from persons;
SELECT DISTINCT city FROM persons;
select * from persons where city = 'lahore';
SELECT * FROM persons WHERE age > 25 AND city='hyd';
SELECT * FROM persons WHERE NOT  city='hyd';
-- LIKE
select ID, FirstName from persons where FirstName LIKE '%al%';
select ID, FirstName from persons where FirstName LIKE 'a%';
select ID, FirstName from persons where FirstName LIKE '%a';
select ID, FirstName from persons where FirstName LIKE '%za';
select ID, FirstName from persons where FirstName LIKE 'a%n';
select ID, FirstName from persons where FirstName LIKE 'm%';
select ID, FirstName from persons where FirstName LIKE 'm______d';
select * from persons where ID  in (1,3,5);
select * from persons where age between 25 AND 30;
select * from persons where ID not between 2 AND 5;
-- AGGREGATE FUNCTIONS
-- SUM, count, MIN, MAX, AVG
select count(ID) from persons;
-- ALIAS (AS)
select count(ID) AS No_of_person from persons;
-- MAX
select MAX(Age) from persons;
-- MIN
select MIN(Age) AS Min_age from persons;
-- AVG
select AVG(Age) AS Avg_age from persons;





create table tbl_category(
c_id int primary key identity(1,1) not null,
c_name varchar(50)

);
INSERT INTO tbl_category (c_name) VALUES ('computers') ,('CD');

create table tbl_product(
p_id int primary key identity(1,1) not null,
p_name varchar(10) not null,
p_price int,
cat_id int foreign key(cat_id) references tbl_category(c_id)

);

INSERT INTO tbl_product (p_name , p_price,cat_id) VALUES ('Infinix', 1000, 1) ,
('Vivo ', 10000, 1),('Samsung', 20000, 1),
('bag 1', 500, 2),('pen', 20, 3);
select * from tbl_product;

SELECT *FROM tbl_category
right JOIN tbl_productON tbl_category.c_id = tbl_product.cat_id;