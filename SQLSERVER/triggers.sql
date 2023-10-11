

create Database Askari_Bank
use Askari_Bank

---Create Table Employee
create Table EmployeeInfo
(
sno int identity(1,1),
Emp_Id int,
Emp_Name varchar(100),
Emp_Country Varchar(100)
)

--Create Table Audit Employee

create Table Employee_Audit
(
sno int identity(1,1),
Emp_Id int,

Audit_Action Varchar(200),
ActionDate Date
)
Select * from EmployeeInfo
Select * from Employee_Audit


insert into EmployeeInfo values(101,'MUDDASIR','JAPAN');

Delete from EmployeeInfo where Emp_Id = 101;

create Trigger InsertAfterTrigger
on EmployeeInfo
for insert
AS
Begin
	Declare @emp_ID int 
	Declare @emp_audit varchar(50)

	Select @emp_ID = Emp_Id from inserted
	Set @emp_audit = 'Inserted action '

	insert into Employee_Audit(Emp_Id,Audit_Action,ActionDate) 
	values (@emp_ID,@emp_audit,getdate())

end


--After Trigger (DML)

/* create Trigger TrgAfterInsert
On EmployeeInfo
For insert
AS
	Begin
	
		Declare @E_ID int
		Declare @Aduit varchar(200)

		Select @E_ID = Emp_Id from inserted
		Set @Aduit = 'Insert Action'

		insert into Employee_Audit (Emp_Id,Audit_Action,ActionDate)
		values (@E_ID,@Aduit,getdate())
		
	End */