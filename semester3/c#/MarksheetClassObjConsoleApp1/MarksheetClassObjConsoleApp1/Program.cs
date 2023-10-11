using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksheetClassObjConsoleApp1
{
    class Marksheet
    {
        int english, mathssub, urdusub, marksSum ;
        double per;

        public void printSubMarks(int eng, int urdu, int maths)
        {
            this.english = eng;
            this.urdusub = urdu;
            this.mathssub = maths;

            Console.WriteLine("english marks "+ this.english);
            Console.WriteLine("maths marks "+ this.urdusub);
            Console.WriteLine("urdu marks "+ this.mathssub);

        }
        public void SumOfMarks()
        {
            this.marksSum = 0;
            this.marksSum = this.english + this.urdusub + this.mathssub;
            Console.WriteLine("Sum Of All Subjects: " + this.marksSum);
        }

        public void percentage()
        {
            this.per = Math.Round((this.marksSum * 100D)/300 , 2);

            Console.WriteLine("Percentage: " + per);
        }
         public void Grade()
        {
            if (per >= 80 && per <= 100)
            {
                Console.WriteLine("Grade A+");
            }
            else  if (per >= 60 && per <= 79)
            {
                Console.WriteLine("Grade B");
            }
            else if (per >= 50 && per <= 59)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("fail");

            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your English Marks");
            int eng = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Urdu Marks");
            int urdu = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Maths Marks");
            int Maths = Convert.ToInt32(Console.ReadLine());

            Marksheet ObjMarksheet = new Marksheet();
            ObjMarksheet.printSubMarks(eng , urdu , Maths);
            ObjMarksheet.SumOfMarks();
            ObjMarksheet.percentage();

            ObjMarksheet.Grade();

            Console.ReadLine();
        }
    }
}
