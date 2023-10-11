using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{

    class Employee
    {
         int empid;
         string empname;
         int empsalary;
        public Employee(int emp_id, string emp_name , int emp_salary)

        {
            this.empid = emp_id;
            this.empname = emp_name;
            this.empsalary = emp_salary;

            
        }
        public void display()
        {
            Console.WriteLine("Employee id is " + this.empid);
            Console.WriteLine("Employee name is " + this.empname);
            Console.WriteLine("Employee salary is " + this.empsalary);

        }
    }
    

   
   
    
    class Program
    {
        static void Main(string[] args)
        {
           Employee emp = new Employee(101, "Ahmed" , 20000);
            emp.display();

        }
    }
}




//students students = new students();
//students.GetBatchCode("Batch 2207F1");
//students.DisplayBatchcode();
//students.batchStart();
//class batch
// {
//     protected string batchCode;

//     public batch()
//     {
//         Console.WriteLine("constructor started");
//     }
//     public void batchStarted()
//     {
//         Console.WriteLine("Batch is started");
//     }
// }
// class students : batch
// {
//     public void GetBatchCode( string b_name) {

//     this.batchCode = b_name;


//     }
//     public void DisplayBatchcode()
//     {
//         Console.WriteLine(this.batchCode);
//     }
//     public void batchStart()
//     {
//         batchStarted();
//     }
// }





