create database demo;

use demo;

CREATE TABLE student(
   ID INT NOT NULL,
   Name varchar(25),
   Phone varchar(12),
   Class INT
);
drop table student;

CREATE TABLE student (
    ID int NOT NULL identity(1,1),
    FirstName varchar(255) NOT NULL,
    LastName varchar(255),
    Age int,
    PRIMARY KEY (ID),
	CHECK (Age>=18),
	City varchar(200) DEFAULT 'karachi'
);

INSERT INTO student( FirstName,LastName, Age,City)VALUES( 'bilal ', 'ahmed', 20,'hyd');


INSERT INTO student(FirstName,LastName, Age)VALUES('bilal', 'khan', 18),('ali ', 'khan', 19);



DELETE FROM student WHERE ID = 1;

ALTER TABLE student ADD Email varchar(255);
ALTER TABLE student DROP COLUMN  Email;
SELECT * FROM student;
Select distinct city from student;
select max(age) from student;
select count(age) from student;
select TOP(1) * from student;
select * from student where id = 2;
select * from student where age >= 20;
select * from student where age >= 20 AND age <= 50;
update student set LastName = 'irfan' where id = 2;
delete from student where id = 4;

CREATE TABLE course (
    C_ID int NOT NULL PRIMARY KEY identity(1,1),
    C_name varchar(255),
);
CREATE TABLE Product (
    ID int NOT NULL PRIMARY KEY identity(1,1),
    name varchar(255),
    price int check (price > 0),
	cat_id int foreign key references course(C_ID)
);
INSERT INTO course(C_name)VALUES('bags'),('mobile'),('pens');
INSERT INTO Product(name,price,cat_id)VALUES('bag 1',500,1),('bag 2',5000,1),('bag 3',1000,1),
('mobile 1',25000,2),('mobile 2',50000,2),('pen1',100,3);
INSERT INTO Product(name,price)VALUES('bag 1',500),('bag 2',5000),('bag 3',1000),
('mobile 1',25000),('mobile 2',50000),('pen1',100);
select * from Product
select * from Product left join course on product.cat_id = course.C_ID;
select * from Product full join course on product.cat_id = course.C_ID;
select * from product where price between 500 AND 5000;
select * from product where id in (2,3);
select * from product where cat_id is null;


CREATE TABLE employee 
(EmpID INT NOT NULL PRIMARY KEY IDENTITY(1,1) , 
        EmpName VARCHAR(50) NOT NULL, 
        Designation VARCHAR(50) NULL, 
		salary int,
		city varchar(100),
        Department VARCHAR(50) NULL, 
        JoiningDate DATETIME NULL
        
    );
	DROP TABLE EMPLOYEE

INSERT INTO Employee
    ( EmpName, Designation,salary,city, Department, JoiningDate)
VALUES 
    ( 'abdullah', 'LAB ASSISTANT',20000,'karachi', 'LAB', GETDATE()),
    ( 'mesum', 'SENIOR ACCOUNTANT',50000,'hyderabad', 'ACCOUNTS', GETDATE()),
    ('zohair', 'ACCOUNTANT',30000,'karachi', 'ACCOUNTS', GETDATE()),
    ('mashood', 'PROGRAMMER',40000,'lahore', 'IT', GETDATE()),
    ('ahsan ahmed', 'SR. PROGRAMMER',10000,'hyderabad', 'IT', GETDATE()),
    ('ali khan', 'ACCOUNTANT',60000,'karachi', 'ACCOUNTS', GETDATE()),
	 ('zohair', 'ACCOUNTANT',30000,'lahore', 'ACCOUNTS', GETDATE()),
    ('mursaleen', 'PROGRAMMER',40000,'lahore', 'IT', GETDATE()),
    ('muhammad ahmed', 'SR. PROGRAMMER',10000,'hyderabad', 'IT', GETDATE()),
    ('aliyan khan', 'ACCOUNTANT',60000,'karachi', 'ACCOUNTS', GETDATE()
	);
	SELECT * FROM EMPLOYEE;

/* Group By with aggregate functions (sum , max, min ,avg , count)*/
select city, sum(salary) as [total salary] from employee group by city;
select city, count(salary) as [total salary] from employee group by city;
/* sub queries */
select * from employee where EmpID in ( select EmpID from employee where salary > 30000);


/* Store procedure  */
create procedure fetchdata
as 
begin
select * from employee


end





/*create procedure emp
as
begin 
select * from employee
end
 execute store procedure 
exec emp;*/

/* create Indexes */
create index I_salary on employee (salary asc); 

drop index employee.I_salary;
