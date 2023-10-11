using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColectionsConsoleApp1
{
    //Collections

    internal class Program
    {
        static void Main(string[] args)
        {


            //Hashtable data store in  Key value

            Hashtable hashtable = new Hashtable();
            hashtable.Add("Phone", 10);
            hashtable.Add("Pens", 20);
            hashtable.Add("Books", 3);

            //Console.WriteLine(hashtable["Books"]);
            foreach (object key in hashtable.Keys)
            {
                Console.WriteLine("Keys: " + key + " value: " + hashtable[key]);

            }














            ////Non generic Collections
            //ArrayList ObjArraylist = new ArrayList();
            // ObjArraylist.Add(101);
            // ObjArraylist.Add("Ali");
            // ObjArraylist.Add("HTML");
            // ObjArraylist.Add(false);
            // //Console.WriteLine(ObjArraylist[3]);
            // foreach (object item in ObjArraylist)
            // {
            //     Console.WriteLine(item);
            // }

            // ObjArraylist.Insert(2, "Rawaha");
            // ObjArraylist.Remove("HTML");

            // Console.WriteLine("New Array List Record");
            // foreach (object x in ObjArraylist)
            // {
            //     Console.WriteLine(x);

            // }

            Console.ReadLine();
        }
    }
}
