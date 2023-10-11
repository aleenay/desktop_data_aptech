using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodConsoleApp1
{
    class Program
    {
        //public void show() // non-static -> instance -> non parameterized
        //{
        //    Console.WriteLine("its show method");
        //}
        public static void show() // static method 
        {
            Console.WriteLine("its show method");
        }
        static void Main(string[] args)
        {
            Program.show();
            //Program objProgram = new Program();
            //objProgram.show();

        }
    }
}
