-- DDL cammand (Data Defination Language)
create database db_2207F1;
use db_2207F1;
-- constraints ( not null , default  , check , unique, primary key , foreign key )
create table tbl_studentData(
id int not null unique auto_increment,
name varchar(100) not null,
age int check (age >= 15),
city varchar(100) default 'karachi'
);
insert into tbl_studentData (name ,age,city) values ('hareem',15,'lahore'),('hamza',25,'hyd'),('bilal',30,'islamabad');
drop table tbl_studentData;
truncate tbl_studentData;
Alter table tbl_studentData auto_increment = 1001;
Alter table tbl_studentData Add column age int;
Alter Table tbl_studentData modify courses varchar (1);
ALter table tbl_studentData change courses std_courses varchar(20);
alter table tbl_studentdata drop age;
ALTER TABLE tbl_studentData MODIFY name VARCHAR (100)  AFTER std_courses; 

select * from tbl_studentdata;
select id ,name from tbl_studentdata;
select * from tbl_studentdata where name = 'ubaid';
delete from tbl_studentdata where id = 1002;

select * from tbl_studentdata where age  >= 22;
select * from tbl_studentdata where city != 'hyd';

select * from tbl_studentdata where age > 18 AND age <25;
select * from tbl_studentdata where age < 18 OR age <21;
select * from tbl_studentdata where (age > 18 AND age < 25) AND city = 'islamabad';
 select * from tbl_studentdata where not city = 'islamabad' and age < 19; 
 SELECT * FROM tbl_studentdata ORDER BY city ASC;
SELECT * FROM tbl_studentdata ORDER BY city DESC;

 
 


