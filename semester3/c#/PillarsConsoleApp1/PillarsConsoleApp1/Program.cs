using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillarsConsoleApp1
{

    class employee //base class
    {
        protected int empid;
        protected string empname;
        protected int empcontactno;
    }
    class permantentEmployees : employee //derived class
    {
        int per_emp_salary;
        int per_emp_hour;
        public void per_emp(int empid, string empname, int empcontactno, int salary, int hour)
        {
            this.per_emp_salary = salary;
            this.per_emp_hour = hour;
            this.empid = empid;
            Console.WriteLine("Employee ID              " + this.empid);
            Console.WriteLine("Employee Name            " + empname);
            Console.WriteLine("Employee Contact no      " + empcontactno);
            Console.WriteLine("Employee Salary          " + this.per_emp_salary);
            Console.WriteLine("Employee Parttime Hours  " + this.per_emp_hour);


        }
    }
    class VisitingEmployess : employee // derived class
    {
        private int visit_emp_salary;
        private int visit_emp_hour;


        public void VisitingEmployessShow(int empid, string empname, int empcontactno, int salary, int hour)
        {
            this.visit_emp_salary = salary;
            this.visit_emp_hour = hour;

            Console.WriteLine("Employee ID              " + empid);
            Console.WriteLine("Employee Name            " + empname);
            Console.WriteLine("Employee Contact no      " + empcontactno);
            Console.WriteLine("Employee Salary          " + this.visit_emp_salary);
            Console.WriteLine("Employee Parttime Hours  " + this.visit_emp_hour);


        }
    }
    //class Employee
    //{
    //    public void xyz(int x)
    //    {
    //        if (x < 0)
    //        {
    //            throw new ArithmeticException("Invalidass ID");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Your Id is: Studennt" + x);
    //        }
    //    }
    //}




    internal class Program
    {
        static void Main(string[] args)
        {

            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (KeyValuePair<int, string> item in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);


            }


            Console.ReadLine();














            //Employee obj = new Employee();

            //try
            //{
            //    obj.xyz(-3);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Error: " + e.Message);
            //}


            //Console.WriteLine("gggg");

            //try
            //{
            // Console.WriteLine("Enter your name");
            //int stdage = Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine(stdage);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error : " + ex.Message);

            //}
            //VisitingEmployess ObjVisting = new VisitingEmployess();
            //ObjVisting.VisitingEmployessShow(101, "Rafay", 03267578, 50000, 2);

            //Console.WriteLine("=======================================");

            //permantentEmployees ObjPer = new permantentEmployees();
            //ObjPer.per_emp(102, "Zohair", 03267578, 50000, 2);
        }
    }


}





//C ObjB = new C();
//ObjB.show();
//Console.ReadLine();


//class A
//{
//  protected  string name = "Zohair";
//}
//class B : A {
//    protected int age = 20;

//}
//class C : B
//{
//    public void show()
//    {
//        Console.WriteLine("Name is" + name +" Age is "  + age);

//    }

//}





//Employee emp = new Employee();
//emp.GetEmployeeData(101,20000,"Ali",20);
//emp.Print();
//multi level inheritance 
//class Human
//{
//    public string name;
//    public void GetName(string na)
//    {
//        name = na;
//    }
//}
//class Man : Human
//{
//    public int age;
//    public void GetAge(int age, string name)
//    {
//        this.age = age;
//    }
//}
//class Employee : Man
//{
//    public int emp_id;
//    public int emp_salary;

//    public void GetEmployeeData(int id, int salary, string name, int age)
//    {
//        emp_id = id;
//        emp_salary = salary;
//        this.name = name;
//        this.age = age;
//    }
//    public void Print()
//    {
//        Console.WriteLine("Emp ID:      " + emp_id);
//        Console.WriteLine("Emp Name:    " + this.name);
//        Console.WriteLine("Emp Salary:  " + emp_salary);
//        Console.WriteLine("Emp Age:     " + this.age);
//    }

//}
//Hierarchical  Inheritance
//class employee //base class
//{
//    public int empid;
//    public int empname;
//    public int empcontactno;
//}
//class permantentEmployees : employee //derived class
//{
//    public int per_emp_salary;
//    public int per_emp_hour;
//}
//class VisitingEmployess : employee
//{
//    public int visit_emp_salary;
//    public int visit_emp_hour;
//}



//class collage
//{

//}
//class department :collage
//{ }
//class batch :department { }