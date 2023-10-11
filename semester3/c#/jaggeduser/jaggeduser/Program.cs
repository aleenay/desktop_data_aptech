using System;

namespace jaggeduser
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];

            jagged[0] = new int[2];
            jagged[1] = new int[4];
            jagged[2] = new int[3];


            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine("enter element at location " + i);


                for (int j = 0; j < jagged[i].Length; j++)
                {

                    jagged[i][j] = int.Parse(Console.ReadLine());


                }


            }


            Console.WriteLine();


            Console.WriteLine("Elemets of jagged arrays are");

            for (int i = 0; i < jagged.Length; i++)
            {

                Console.WriteLine("At location  " + i);

                for (int j = 0; j < jagged[i].Length; j++)
                {

                    Console.WriteLine(jagged[i][j]);


                }

                Console.WriteLine();

            }
        }
    }
}
