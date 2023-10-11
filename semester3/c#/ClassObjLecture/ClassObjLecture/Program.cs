using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjLecture
{
    public class Student
    {
        public int id;//field or data member   
        public String name;//field or data member
        public void insertData(int u_id, string u_name)
        {
            id = u_id;
            name = u_name;  
        }
        public void display()
        {
           
            Console.WriteLine( "User Id: " + id + "\nUsername:  " + name);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();//creating an object of Student
            Student s2 = new Student();//creating an object of Student    

            s1.insertData(1001, "naveera");
            s2.insertData(1002, "fatima");

            s1.display();
            s2.display();

        }
    }
}
