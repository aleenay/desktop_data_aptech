create database  db_employeeRecord;
use db_employeeRecord;

create table emp(
emp_id int not null primary key auto_increment,
emp_name varchar(20),
c_id int ,
foreign key(c_id) references emp_location (c_id)
);
create table emp_location(
c_id int not null primary key auto_increment,
c_name varchar(20)
);
insert into emp_location (c_name) values ('karachi'),('lahore'),('hyderabad'),('multan');
insert into emp_location (c_name) values ('islamabad'),('Quetta');
insert into emp (emp_name,c_id) values ('aliyan',1),('rizwan',2),('muniza',3),('Hareem',4);
select * from emp;
select * from emp_location;
-- inner join 

select * from emp inner join emp_location
 on emp.c_id = emp_location.c_id;
 
select emp.emp_id , emp.emp_name,emp_location.c_name from emp inner join emp_location 
 on emp.c_id = emp_location.c_id;
 
select emp.emp_id , emp.emp_name,emp_location.c_name from emp inner join emp_location 
 on emp.c_id = emp_location.c_id 
where emp_location.c_name = 'karachi';

select * from emp Left join emp_location  on emp.c_id = emp_location.c_id;
select * from emp right join emp_location  on emp.c_id = emp_location.c_id;
select * from emp;
truncate table emp;
update emp set emp_name ='Hassan' where emp_id = 1;
update emp set emp_name ='Ehtisham' where emp_id in (2,3);

