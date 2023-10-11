using System;
using System.Collections;

using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2207B2_ConsoleApp1
{



    internal class Program
        {
        static void Main(string[] args)
        {

            //Generic Collection

            Dictionary<string, string> ObjDic = new Dictionary<string, string>();
            ObjDic.Add("name", "Ali");
            ObjDic.Add("courses", "HTml");
           
            
            
            
            
            
            
            
            
            
            
            //Console.WriteLine(ObjDic["courses"]);
            //foreach(KeyValuePair<string, string> item in ObjDic)
            //{
            //    Console.WriteLine("Key is:  " + item.Key +" And value is " + item.Value);
            //}

            //foreach (var item in ObjDic)
            //{
            //    Console.WriteLine("Key is:  " + item.Key + " And value is " + item.Value);
            //}














            // SortedList mylist = new SortedList();
            // mylist.Add("name","ali");
            // mylist.Add("enrol", "Student1234");
            // mylist.Add("batch", "2106B1");
            // for (int i = 0; i < mylist.Count; i++)
            // {
            //     Console.WriteLine(mylist.GetByIndex(i));
            // }
            // if (!mylist.ContainsKey("center"))
            // {
            //     mylist.Add("center", "aptech");
            // }
            //Console.WriteLine("\tAfter Adding center");
            // for (int i = 0; i < mylist.Count; i++)
            // {
            //     Console.WriteLine(mylist.GetByIndex(i));
            // }
            // if (mylist.ContainsKey("batch"))
            // {
            //     mylist["batch"] = "2109c1";
            // }
            // Console.WriteLine("\tAfter changing batch");
            // for (int i = 0; i < mylist.Count; i++)
            // {
            //     Console.WriteLine(mylist.GetByIndex(i));
            // }

            // Console.WriteLine("\tShowing key and value together");
            // for (int i = 0; i < mylist.Count; i++)
            // {
            //     Console.WriteLine(mylist.GetKey(i) + ": " + mylist.GetByIndex(i));
            // }
            // Console.WriteLine("\tRemoving location 1");
            // mylist.RemoveAt(1);
            // for (int i = 0; i < mylist.Count; i++)
            // {
            //     Console.WriteLine(mylist.GetKey(i) + ": " + mylist.GetByIndex(i));
            // }

            //Hashtable hashtable = new Hashtable()
            //{
            //    { "id", 101},
            //    { "name","ali"},
            //    {"Salary" ,250000 }
            //};
            //// Console.WriteLine(hashtable["id"]);
            //foreach (object x in hashtable.Keys)
            //{
            //    Console.WriteLine( "Keys " +x + " values " + hashtable[x]);
            //}




















            // Hashtable Objhashtable = new Hashtable();
            // Objhashtable.Add("Phone", 10);
            // Objhashtable.Add("Pens", 20);
            // Objhashtable.Add("Books", 3);
            //Console.WriteLine(Objhashtable["Books"]);
            // foreach (object key in Objhashtable.Keys)
            // {
            //     Console.WriteLine("Keys: " + key + " value: " + Objhashtable[key]);

            // }




            //ArrayList objArraylist = new ArrayList();
            //objArraylist.Add(1001);
            //objArraylist.Add("sarim");
            //objArraylist.Add(true);
            //foreach (object i in objArraylist) {
            //    Console.WriteLine(i);
            //}
            //objArraylist.Insert(1, "Fatima"); //New Value insert on index number

            //Console.WriteLine("===================================");
            //foreach (object i in objArraylist)
            //{
            //    Console.WriteLine(i);
            //}

            //objArraylist.Remove("sarim"); 

            //Console.WriteLine("===================================");
            //foreach (object i in objArraylist)
            //{
            //    Console.WriteLine(i);
            //}









            //Hashtable obj = new Hashtable();
            //obj.Add("name","zohair");
            //obj.Add("ID", 101);


            //Console.WriteLine(obj["ID"]);






            //ArrayList obj = new ArrayList();
            //obj.Add("zohair");
            //obj.Add("Arshman");
            //obj.Add("Rafay");
            ////Console.WriteLine(obj[1]);
            //for (int i = 0; i < obj.Count; i++)
            //{
            //    Console.WriteLine(obj[i]);
            //}













            //for (int i = 0; i < obj.Count; i++)
            //    Console.WriteLine(obj[i]);

            //Console.WriteLine("WITH FOREACH");

            //foreach (string s in obj)
            //    Console.WriteLine(s);

















            //Student student = new Student()
            //{
            //    Name = "zohair",
            //    Age = 18,
            //    Grade = 12
            //};

            //Teacher teacher = new Teacher()
            //{
            //    Name = "Jane",
            //    Age = 30,
            //    Subject = "Math"
            //};

            //Console.WriteLine("Student Information:");
            //Console.WriteLine("Name: {0}", student.Name);
            //Console.WriteLine("Age: {0}", student.Age);
            //Console.WriteLine("Grade: {0}", student.Grade);

            //Console.WriteLine("Teacher Information:");
            //Console.WriteLine("Name: {0}", teacher.Name);
            //Console.WriteLine("Age: {0}", teacher.Age);
            //Console.WriteLine("Subject: {0}", teacher.Subject);











            // A obj = new A(101);

            //mobile2 ObjMobile = new mobile2();
            //ObjMobile.update();

            //Console.WriteLine(ObjEmp.id);


            //employee objEmp = new employee();

            // Console.WriteLine("Enter your ID");
            // int e_id = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Enter your name");
            // string e_name = Console.ReadLine();

            // Console.WriteLine("Enter your Salary");
            // int e_salry = Convert.ToInt32(Console.ReadLine());

            // objEmp.getdata(e_id, e_name, e_salry);
            // objEmp.printata();




            //int[][] arrJagged = new int[4][];
            //arrJagged[0] = new int[5] { 510, 220, 630, 40, 50 };
            //arrJagged[1] = new int[2] { 101, 120 };
            //arrJagged[2] = new int[1] { 107 };

            //arrJagged[3] = new int[4] { 210, 420, 340, 460 };

            //Console.WriteLine(arrJagged[1][1]);



















            //Program.display2("mesum");
            //Program ObjProgram = new Program();
            ////ObjProgram.batch("Rafay 2207B2" , 101);
            //ObjProgram.show("Rafay");


            //Console.WriteLine("Write 3 Values");
            //Console.WriteLine("---------------");

            //string[] names = new string[3];

            //for (int i = 0; i < 3; i++)
            //{
            //    names[i] = Console.ReadLine();
            //}

            //Console.WriteLine("---------------");
            //Console.WriteLine("Arrays Values");
            //Console.WriteLine("---------------");

            //for (int j = 0; j < 3; j++)
            //{
            //    Console.WriteLine(names[j]);
            //}




            //array in c#
            //string[] std_name = { "Zohair", "Huzaifa", "Rafay" };
            ////Console.WriteLine(std_name[1]);
            //   foreach (string std in std_name)
            //{
            //    Console.WriteLine(std);
            //}

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

            //string[,] names = {
            // { "Mesum" ,"Rafay" ,"Umer" },
            // { "Huzaifa" ,"Musaib" ,"Sarim" },
            // { "Zohair" ,"Abdullah" ,"Arshman" },
            //};
            //Console.WriteLine(names[2,2]);

            //string[,] names = 
            //{
            //   { "ali" , "ahmed" },
            //    { "fatima" , "warda" },

            //};
            // Console.WriteLine(names[1, 1]);


            //jagged array 

            //int[][] arrJagged = new int[4][];
            //arrJagged[0] = new int[5] { 510, 220, 630, 40, 50 };
            //arrJagged[1] = new int[2] { 101, 120 };
            //arrJagged[2] = new int[1] { 107 };

            //arrJagged[3] = new int[4] { 210, 420, 340, 460 };

            //Console.WriteLine(arrJagged[0][4]);




            //int[][] arr = new int[2][];
            //arr[0] = new int[2] { 10, 20 };
            //arr[1] = new int[3] { 10, 20, 30 };

            //Console.WriteLine(arr[0][1]);












            //for (int i = 0; i < names.GetLength(0); i++)
            //{
            //    for (int j = 0; j < names.GetLength(1); j++)
            //    {
            //        Console.Write(names[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}















            //For loop While Loop do while
            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    i++;
            //} while (i > 10);











            //int i = 0;
            //while (i <= 20)
            //{
            //    Console.WriteLine(i);
            //   i++;
            //}

            //int x = Convert.ToInt32(Console.ReadLine());


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(x + "x" + i + "=" + (x*i));
            //}













            Console.ReadLine();


                //Arthemetic operators + - * / %
                //int x = 10;
                //int y = 20;
                //Console.WriteLine( "sum of x and y " + (x + y ));
                //Console.WriteLine("sub of x and y " + (x - y));
                //Console.WriteLine("Multiply of x and y " + (x * y));
                //Console.WriteLine("Divide of x and y " + (x / y));

                // Assignment Operator += -= /= *=

                //int x = 10;
                //int res = 40;
                //Console.WriteLine( x += res);

                // Relational Operator ==  !=  >= <= > <
                //int x = 10;
                //int res = 0;
                //Console.WriteLine( x <= res);


                //Logical Operator && || !
                //int x = 20;
                //int y = 20;
                //bool res = !(x == y);
                //Console.WriteLine(res);

                // if statement 
                //int x = 20;
                //int y = 20;
                //string car = Console.ReadLine();

                //if (car != "" )
                //{
                //    Console.WriteLine("Its not a empty");

                //    if(car == "civic")
                //    {
                //        Console.WriteLine("Its a civic");

                //    }
                //    else

                //    {
                //        Console.WriteLine("Its not civic");

                //    }

                //}
                //else if (car == "")
                //{
                //    Console.WriteLine("Its a empty");
                //}
                //else if (car == "alto")
                //{
                //    Console.WriteLine("Its a alto");
                //}
                //else
                //{
                //    Console.WriteLine("not found");
                //}

                //string name = "Ali";
                //Console.WriteLine("Enter your 1st name " );

                //string std_name = Console.ReadLine();


                //Console.WriteLine("Name is " + std_name);

                //Console.WriteLine("Enter your age ");
                //int age = Convert.ToInt32( Console.ReadLine());
                //Console.WriteLine("age is " + age);
                //string grade = Console.ReadLine();
                //switch (grade)
                //{
                //    case "A":
                //        Console.WriteLine("Grade A");
                //        break;
                //        case "B":
                //        Console.WriteLine("Grade B");
                //        break;
                //        case "C":
                //        Console.WriteLine("Grade C");
                //        break;
                //    default:
                //        Console.WriteLine("Fail");
                //        break;
                //}





            }

        
        
        
        }
    }
//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//}

//class Student : Person
//{
//    public int Grade { get; set; }
//}

//class Teacher : Person
//{
//    public string Subject { get; set; }
//}
//Constructor
//class A
//{
//   public A(int x)
//    {

//       display(x);
//    }
//    void display(int y)
//    {
//        Console.WriteLine("contructor working " + y);
//    }
//    public void show()
//    {

//    }
//}
//public void display() //non static // user define non - param
// {
//     Console.WriteLine("Its a display method");
// }

// public static void display2(string x) //non static // user define non - param
// {
//     Console.WriteLine(x);
// }
// public void batch(string x , int i)
// {
//     Console.WriteLine(x + ' ' + i );
// }

// public void show(string x = "default value")
// {
//     Console.WriteLine(x );
// }

//class employee
//{
//    private int ID;
//    public string name;
//    public int salary;

//    public void getdata(int emp_id, string emp_name, int emp_salary)
//    {
//        this.ID = emp_id;
//        this.name = emp_name;
//        this.salary = emp_salary;


//    }
//    public void printata()
//    {
//        Console.WriteLine("Employee ID :      " + this.ID);
//        Console.WriteLine("Employee name :    " + this.name);
//        Console.WriteLine("Employee salary :  " + this.salary);

//    }


//}
// Over riding
//class mobile1 // base class
//{

//    public virtual void update()
//    {
//        Console.WriteLine("First Update");
//    }
//}
//class mobile2 : mobile1 // derived class
//{
//    public override void update()
//    {
//        Console.WriteLine("new Update");
//    }
//}

//class employee // base class
//{
//    // Over loading
//    public void getdata()
//    {
//        Console.WriteLine("Get if method 1");
//    }
//}
//class parttime_emp : employee // derived class
//{
//    public void getdata(int x)
//    {
//        Console.WriteLine("Get second method " + x);

//    }
//}