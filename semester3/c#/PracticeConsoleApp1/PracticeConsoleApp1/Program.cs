using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp1
{
    abstract class mobile1
    {

        public void latestupdate()
        {
            Console.WriteLine("latest update");
        }
    }
    class mobile2 : mobile1
    {
        public void update1()
        {
            Console.WriteLine("old update 1");
        }
    }
    class Program

    {

        static void Main(string[] args)
        {
            mobile2 obj1 = new mobile2();
            obj1.update1();
            obj1.latestupdate();



            try
            {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Squre of {num} is {num * num}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);

            }

            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    Console.Write("Error info:" + ex.Message);
            //}















            //mobile2 objmobile2 = new mobile2();

            //objmobile2.update1();
            //objmobile2.latestupdate();














            //mobile2 objm = new mobile2();
            //objm.working();













            //optionalparameter optionalparameter = new optionalparameter();
            // optionalparameter.message();





            //mobile1 mobile2 = new mobile2();
            //mobile2.working();


            //1.variables 2.datatypes 3.userinput 

            /* Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Name is: " + name);
            Console.WriteLine("Enter your number");
            int num1=Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("solution: " + (num1 + num2));
            */

            //Operators -> 1.Arthemetic 2.Assignment 3.Comparison 4.Logical
            //int a = 10;
            //int b = 20;
            //Console.WriteLine("The value of a + b = " + (a+b));
            //Console.WriteLine("The value of a - b =  " + (a - b));
            //Console.WriteLine("The value of a * b = " + (a * b));
            //Console.WriteLine("The value of a / b = " + (a / b));
            ////assignment Operator
            //Console.WriteLine("The value of a += b = " + (b+= a));
            //// comparison Operator
            //Console.WriteLine("The value of  a > b = " + (a > b));
            ////logical && || !
            //Console.WriteLine(20 == 2 || 30 ==0);
            //Console.WriteLine(!false);

            //Console.WriteLine("Enter Your table Number: ");
            //int tblNum = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(tblNum + "x" + i + "=" + tblNum*i);
            //}






            //array in c#

            //string[] std_names = { "Ali", "fatima", "naveera", "warda" };
            //foreach (var std in std_names)
            //{
            //    Console.WriteLine(std);
            //}

            ////Console.WriteLine(std_names[0]);

            //for (int i = 0; i < std_names.Length; i++)
            //{

            //Console.WriteLine(i + std_names[i]);

            //}



            //string[] students = { "Ali", "Iqra", "Ahmed", "moeez" };
            //Console.WriteLine(students[0]);
            //Console.WriteLine(students.Length);

            // for (int i = 0; i < students.Length; i++)
            //{
            //    Console.WriteLine(students[i]);
            // }
            // Array.Sort(students); // sorts an array alphabetically or in an ascending order
            //foreach (var item in students)
            // {
            //    Console.WriteLine(item);

            //}





            //multidimensional array
            //string[,] names = 
            // {
            //    { "ali" , "ahmed" },
            //    { "fatima" , "warda" },

            //};
            ////Console.WriteLine(names[1, 1]);
            //for (int i = 0; i < names.GetLength(0); i++)
            //{
            //    for (int j = 0; j < names.GetLength(1); j++)
            //    {
            //        Console.Write(names[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}












            //jagged array 

            //int[][] arrJagged = new int[4][];
            //arrJagged[0] = new int[5] { 510, 220, 630, 40, 50   };
            //arrJagged[1] = new int[2] { 101, 120 };
            //arrJagged[2] = new int[1] { 107  };

            //arrJagged[3] = new int[4] { 210 ,420,340,460 };

            //Console.WriteLine(arrJagged[0][4]);




            //int[][] arr = new int[2][];
            //arr[0] = new int[2] { 10, 20 };
            //arr[1] = new int[3] { 10, 20, 30 };

            //Console.WriteLine(arr[0][1]);









            //int[,] numbers = {  { 1, 4, 2 }, { 3, 6, 8 } };
            //Console.WriteLine(numbers[1,1]);
            //for (int i = 0; i < numbers.GetLength(0); i++)
            //{
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        Console.Write(numbers[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //jagged array -> single
            //int[][] arr = new int[2][];
            //arr[0] = new int[2] { 10, 20 };
            //arr[1] = new int[3] { 10, 20, 30 };

            //Console.WriteLine(arr[0][1]);


            Console.ReadLine();






        }
    }
}
//abstract class mobile1
//{

//    public void latestupdate()
//    {
//        Console.WriteLine("latest update");
//    }
//}
//class mobile2 : mobile1
//{
//    public  void update1()
//    {
//        Console.WriteLine("old update 1");
//    }
//}

//public void show()
//{
//    Console.WriteLine("method1");
//}
//public void show(int x)
//{
//    Console.WriteLine("method two  " + x);

//}

//method overriding
//class mobile1
//{
//    public virtual  void working()
//    {
//        Console.WriteLine("working android version 10");
//    }
//}
//class mobile2 : mobile1
//{
//    public override  void working()
//    {

//        Console.WriteLine("working android version 12");
//    }
//}
//Students obj = new Students();
//obj.getdata();
//class Aptech
//{
//    protected string InstituteName = "Aptech NN";
//}
//class Depart : Aptech
//{
//    protected string dep = "Academics";
//}
//class Faculty : Depart
//{
//    protected string techer = "Miss Aleena";

//}
//class Students : Faculty
//{
//    protected string std_name = "Hatim";

//    public void getdata()
//    {
//        Console.WriteLine(InstituteName);
//        Console.WriteLine(dep);

//    }
//}






// parttime_emp objpt = new parttime_emp();
//parttime_emp objpt2 = new parttime_emp();

//objpt.getdataPt(101, "Huzaifa", 20, 20000, "4 hours");
//Console.WriteLine("----------------");
//objpt2.getdataPt(102, "Naveera", 20, 50000, "5 hours");
// class employee
//{
//    protected int id;
//    protected string name;
//    protected int age;
//    protected int salary;


//}
//class per_emp : employee
//{
//    public void getdata(int emp_id, string emp_name, int emp_age, int emp_salary, string medical)
//    {
//        this.id = emp_id;
//        this.name = emp_name;
//        this.age = emp_age;
//        this.salary = emp_salary;

//        Console.WriteLine("Emp ID        " + this.id);
//        Console.WriteLine("Emp Name      " + this.name);
//        Console.WriteLine("Emp Age       " + this.age);
//        Console.WriteLine("Emp salary    " + this.salary);
//        Console.WriteLine("Emp medical   " + medical);

//    }
//}
//class parttime_emp : employee
//{

//    public void getdataPt(int emp_id, string emp_name, int emp_age, int emp_salary, string hours)
//    {
//        this.id = emp_id;
//        this.name = emp_name;
//        this.age = emp_age;
//        this.salary = emp_salary;

//        Console.WriteLine("Emp ID        " + this.id);
//        Console.WriteLine("Emp Name      " + this.name);
//        Console.WriteLine("Emp Age       " + this.age);
//        Console.WriteLine("Emp salary    " + this.salary);
//        Console.WriteLine("Emp Hours    " + hours);


//    }
//class employee
//{
//  protected int emp_id;
//    protected string name;
//    protected int age;
//}
//class permnntemp : employee
//{
//    int per_emp_salary;
//    string per_emp_hour;
//    public void getpermnntemp(int id , string name , int age , int salary, string hour )
//    {
//        this.emp_id = id;
//        this.name = name;
//        this.age = age;
//        salary = 2000;
//        hour = "4 hour";
//        Console.WriteLine("Employee ID:     " + this.emp_id);
//        Console.WriteLine("Employee Name:     " + this.name);
//        Console.WriteLine("Employee Age:     " + this.age);
//        Console.WriteLine("Employee Salary:     " + salary);
//        Console.WriteLine("Employee Hour:     " + hour);

//    }
//}
//class parttimeemp : employee
//{
//    int parttime_emp_s;
//    string parttime_emp_hour;

//}
//optional parameter
//class optionalparameter
//{
//    public void message(string message = "default value")
//    {
//        Console.WriteLine( message);
//    }
//}


//method overriding
//class mobile1
//{
//    public virtual void working()
//    {
//        Console.WriteLine("working android version 10");
//    }
//}
//class mobile2 : mobile1
//{
//    public override void working()
//    {
//        base.working();
//        Console.WriteLine("working android version 12");
//    }
//}