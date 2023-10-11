create database db_demo
use db_demo
CREATE TABLE tbl_category (
    cat_id int not null primary key identity(1,1),
	cat_name varchar(200)
);


create Table cat_Audit
(
sno int identity(1,1),
cat_id int,

Audit_Action Varchar(200),
ActionDate Date
)
select * from tbl_category;
select * from cat_Audit;


insert into tbl_category(cat_name) values ('sat');
UPDATE tbl_category
SET cat_name = 'mobile'
WHERE cat_id = 5;

Delete from tbl_category where cat_id = 3

create Trigger TrgAfterInsert
On tbl_category
For insert
AS
	Begin
		Declare @C_ID int
		Declare @Aduit varchar(200)
		


		Select @C_ID = cat_id from inserted
		Set @Aduit = 'Insert Action'

		insert into cat_Audit (cat_id,Audit_Action,ActionDate)
		values (@C_ID,@Aduit,getdate())
		
	End

create Trigger TrgDelete
On tbl_category
For delete
AS
	Begin
		Declare @C_ID int
		Declare @Aduit varchar(200)
		


		Select @C_ID = cat_id from deleted
		Set @Aduit = 'delete Action'

		insert into cat_Audit (cat_id,Audit_Action,ActionDate)
		values (@C_ID,@Aduit,getdate())
		
	End

create Trigger TrgUpdate
On tbl_category
For update
AS
	Begin
		Declare @C_ID int
		Declare @Aduit varchar(200)
		


		Select @C_ID = cat_id from inserted
		Set @Aduit = 'update Action'

		insert into cat_Audit (cat_id,Audit_Action,ActionDate)
		values (@C_ID,@Aduit,getdate())
		
	End
select * from tbl_category;
select * from cat_Audit









CREATE DATABASE testDB;

CREATE TABLE product (
    pro_id int NOT NULL identity(1,1),
    pro_name varchar(300),
    cat_id int,
    PRIMARY KEY (pro_id),
    FOREIGN KEY (cat_id) REFERENCES tbl_category(cat_id)
);





	drop table tbl_category;
drop table product;

insert into tbl_category(cat_name) values ('hardware');
insert into product(pro_name,cat_id) values ('mobile 23',2),('book 1 ',4),('book2 ',4),
('infinix ',2),('pencil',3),('pen ',3),('realme',2),('nokia',2),('book english',4);
insert into product(pro_name) values ('mobile 23'),('book 1 '),('book2 ');
select * from product;
select cat_name as catgeory_name from tbl_category;

select * from product inner join tbl_category on product.cat_id = tbl_category.cat_id ;
select * from product left join tbl_category on product.cat_id = tbl_category.cat_id ;
select * from product right join tbl_category on product.cat_id = tbl_category.cat_id ;
select * from product full outer join tbl_category on product.cat_id = tbl_category.cat_id ;
select * from product self join tbl_category on product.cat_id = tbl_category.cat_id ;

