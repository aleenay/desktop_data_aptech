using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkesheetwithClassObjConsoleApp1
{
    class Marksheet{
        int english, maths, urdu;

        public void print(int eng , int urdu , int maths)
        {
            this.english = eng;
            this.urdu = urdu;
            this.maths = maths;

            Console.WriteLine("english marks", this.english);
            Console.WriteLine("maths marks", this.urdu);
            Console.WriteLine("urdu marks", this.maths);

        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            Marksheet ObjMarksheet = new Marksheet();
            ObjMarksheet.print(100, 300, 500);
            Console.ReadLine();
        }
    }
}
