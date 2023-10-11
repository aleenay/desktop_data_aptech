using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisionConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("revision");
            Console.WriteLine("2211c3");
            // int bool string char float double 
          
            Console.WriteLine("Enter your name");
            string name =Console.ReadLine();
            Console.WriteLine("Enter your age");

            int age = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(name + ' ' + age);
            Console.ReadLine();
        }
    }
}
