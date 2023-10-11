using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using first_space;
// access Assembly1
//using Assembly2;
using NamespaceLecture;

namespace NamespaceLecture
{
    //public class StudentName
    //{
    //    internal string name = "zohair";
    //}

    class Program
    {
        static void Main(string[] args)
        {

            string std_name = "Ali";
            int std_age = 20;
            string message = "My name is {0} and age is {1} ";
            string x = string.Format(message,  std_age,std_name);
            Console.WriteLine(x);

            //int age = 30;
            //string name = "dania";
            //string message = "Hello, my name is {0} and I am {1} years old.";
            //string formattedMessage = string.Format( message,age,name);

            //Console.WriteLine(formattedMessage);
            Console.ReadLine();
        }
    }
}

//namespace Assembly2
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            StudentName student = new StudentName();

//            // accessing name field from Assembly1
//            Console.Write(student.name);
//            Console.ReadLine();
//        }
//    }
//}


//batch2207B2.std obj = new batch2207B2.std();
//obj.func();


//first approach
//first_space.A.func();

//second approach
//A.func();
//Console.WriteLine("main method runn");

//namespace first_space
//{
//    class C
//    {
//        internal string name2 = "Ali khan";

//    }
//    class A
//    {
//        public static void func()
//        {
//            Console.WriteLine("Inside first_space");
//        }
//    }
//}
