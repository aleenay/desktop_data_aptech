create database  db_studentData;
use db_studentData;
use db_employeerecord;

-- create table with contraints  
-- create table stdData(
-- std_id int not null primary key auto_increment,
-- std_name varchar(500),
-- std_email varchar(100),
-- std_phoneno bigint ,
-- std_age int check (std_age >= 18),
-- std_city varchar(500) default 'khi'

-- );

create table std_data(
std_id int not null unique auto_increment,
std_name varchar(20),
std_city varchar(20) default 'karachi',
std_age int check (std_age >=18)
);


insert into std_record (std_name,std_age) values ('ahmed',21);
insert into stddata (std_name,std_email,std_phoneno,std_age) values ('aliya','a123@gmail.com',03214567676,18);
truncate stddata;
drop table std_record;
drop database db_studentData;
 
ALTER TABLE stddata AUTO_INCREMENT = 101;
ALTER TABLE std_data ADD COLUMN std_course VARCHAR (25);
ALTER TABLE std_data MODIFY std_course VARCHAR (100);
ALTER TABLE std_data CHANGE std_course std_subject VARCHAR (20);

ALTER TABLE std_data DROP std_subject;
ALTER TABLE std_data MODIFY std_course VARCHAR (25)  AFTER std_name; 

RENAME TABLE std_data TO std_record; 

select * from std_record;
select * from std_record where std_id = 3;
select std_id, std_name ,std_city from std_record;
select * from std_record where std_city = 'karachi';
select * from std_record where std_age >= 18;
select * from std_record where std_city != 'hyd';
select * from std_record where std_age < 18 AND std_age <21;
select * from std_record where std_age < 18 OR std_age <21;
select * from std_record where (std_age >= 18 AND std_age < 21) AND std_city = 'hyd';
 select * from std_record where not std_city = 'karachi' and std_age < 19; 
 
 select * from emp;
 
 create table emp(
emp_id int not null primary key auto_increment,
emp_name varchar(20),
emp_salary int check (emp_salary >0),
emp_designation varchar(30)
);
insert into emp (emp_name,emp_salary,emp_designation) values ('aliya',90000,'CHA'),
('aliya',90000,'CHA'),
('ALI',40000,'ABC'),
('aliyan',190000,'CHA'),
('Rameez',10000,'Dev'),
('Rameez Ahmed',90000,'CHA'),
('Moiz',90000,'Manager'),
('Aziz',90000,'CHA'),
('Aziz',20000,'CHA'),

('Aziz',30000,'CHA')
;
select * from emp;
select * from emp where emp_salary between 10000 AND 30000;

select * from std_record where std_id not in (1,3,5);
select * from std_record where std_id between 2 AND 5;
select * from std_record where std_id not between 2 AND 3;
  -- Like Queries 
  select * from emp;
  select * from emp where emp_name LIKE '_h%';
  
select * from emp where emp_name LIKE 'a%';
select * from emp where emp_name LIKE '%a';
select * from emp where emp_name LIKE 'a%i';
select * from emp where emp_name LIKE '%am%';
select * from emp where emp_name LIKE '_a%';
select * from emp where emp_name LIKE '__m%';
select * from emp where emp_name LIKE '___e%';
select * from emp order by emp_name asc;
--  Order By
select * from emp order by emp_name desc;
select * from emp order by emp_name asc;
select * from emp order by emp_designation desc;
-- Distinct 
select distinct emp_name from emp;
select distinct emp_designation from emp;

select distinct emp_designation from emp ;
select distinct emp_designation from emp order by emp_designation;

-- primary key or foreign key
create database schoolmanagement;
use schoolmanagement;
drop table std_data;
create table std_city(
c_id int primary key not null auto_increment,
c_name varchar(20) not null

);
create table std_data(
std_id int not null primary key auto_increment,
std_name varchar(20) not null,
std_marks bigint ,
std_percentage bigint,
std_city int not null,
foreign key (std_city) references std_city(c_id)

);
insert into std_city (c_name) values('karachi'),('hyderabad'),('lahore');
select * from std_city;
select * from std_data;
insert into std_data (std_name,std_marks,std_percentage,std_city) values('farooq',60,60,2),('Hamza khan',30,30,3),
('aliya',10,20,1);

select std_id,std_name,std_percentage,  if(std_percentage  > 80 ,"Pass" ,"Fail") AS Result  from std_data;

 
select std_id,std_name,std_percentage, 
case
	when std_percentage >= 80 and std_percentage <= 100 then "A1"
    when std_percentage >= 60 and std_percentage < 80 then "A"
    when std_percentage >= 40 and std_percentage < 60 then "B"
	when std_percentage < 40  then "Fail"
	ELSE "Not Correct %"
end    
 AS Grade  from std_data;

create table ab(
id int not null primary key auto_increment,
DOB date 

);
-- INSERT INTO ab (DOB) VALUES (STR_TO_DATE('1-01-2012', '%d-%m-%Y') ) ;
INSERT INTO ab (DOB) VALUES ('2012-01-01') ;
select * from ab;
select * from emp;

