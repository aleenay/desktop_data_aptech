using _14June23ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14June23ConsoleApp1
{
   // Access Modifiers Public Private Protected
   class students
    {
       protected string name = "ali";
        public void printdata()
        {
            Console.WriteLine(name);
        }
        public void printdata2(int x)
        {
            Console.WriteLine(x);
        }
    }
   class batch : students
    {
        string batchCode = "2207g1";
        public void getstudentdata()
        {
            Console.WriteLine( this.name + batchCode);
        }
    }



    class Program
    {

        static void Main(string[] args)
        {
            batch obj = new batch();
            obj.getstudentdata();
                obj.printdata2(20);
           

           //ObjBatch.BatchStarted();
            


            Console.ReadLine();

        }
    }
}


//student student = new student();
//string b_code = Console.ReadLine();

//student.GetBatchCode(b_code);
//student.Print();
//class batch
//{
//    protected string batchCode;

//    protected void BatchStarted()
//    {

//        Console.WriteLine("Batch is started");
//    }
//}
//class student : batch
//{
//    public void GetBatchCode(string batch_Code)
//    {
//        this.batchCode = batch_Code;
//    }
//    public void Print()
//    {
//        Console.WriteLine(this.batchCode);
//    }
//}


//class student
//{
//    string name;
//    int age;
//    string email;
//    public student(string name, int std_age, string std_email)
//    {

//        this.name = name;
//        this.age = std_age;
//        this.email = std_email;


//    }
//    public void display()
//    {
//        Console.WriteLine(this.name);
//        Console.WriteLine(this.age);
//        Console.WriteLine(this.email);

//    }

//}
//student std = new student("Huzaifa", 20, "huzaifa@gmail.com");
//std.display();
//student ObjStd = new student();
//Console.WriteLine("Enter your name");
//string std_name = Console.ReadLine();
//Console.WriteLine("Enter your age");

//int std_age = Convert.ToInt32(Console.ReadLine());

//ObjStd.insertData(std_name, std_age);


//ObjStd.display();
//string name;
//int age;
//public void insertData(string n , int a)
//{
//    name = n;
//    age = a;
//}
//public void display()
//{

//    Console.WriteLine("name is: " + name);
//    Console.WriteLine("age is: " +age);
//}


//Program obj = new Program();
//obj.display();
//obj.display(20, "ali");
//A objA = new A();
//objA.show();
//object oriented Programming 
// what is namespace ?


//public void display()
//{
//    Console.WriteLine("Working method");

//}
//public void display(int x , string y)
//{
//    
//Console.WriteLine(x + y);
//}


//external namespace
//namespace first_space
//{
//    class A
//    {
//        public  void show()
//        {
//            Console.WriteLine("First namespace");
//        }
//    }
//}
