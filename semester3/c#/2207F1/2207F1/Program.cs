using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//using first_namespace;
namespace _2207F1
{

    


    internal class Program
    {
       
        static void Main(string[] args)
        {
            try
            {

int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( x);
            }
            catch (Exception e) {
                Console.WriteLine( "Error :  " + e.Message);

            }
          
            











            //Program p1 = new Program();
            //p1.display(100);
            //p1.display(100, 200);
            //Console.ReadLine();


            // method overloading
            //public void display(int a)
            // {
            //     Console.WriteLine("Arguments: " + a);
            // }

            // // method with two parameters
            // public void display(int a, int b)
            // {
            //     Console.WriteLine("Arguments: " + a + " and " + b);
            // }
            //mobile2 objmobile2 = new mobile2();
            //objmobile2.update();

            //// var x = ["A",20]
            //string[] x = { "Moeez", "wajahat", "Hamad" ,"Ali raza"};

            //Console.WriteLine(x.Length);
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("--------------------");
            //Array.Sort(x);
            //for (int i = 0; i < x.Length; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}

            ////multidimensional array
            //Console.WriteLine("---------Multidimensional Array-----------");

            //string[,] std_names =
            //{
            //   { "Moeez", "wajahat", "Hamad" ,"Ali raza"},
            //{ "mahnoor", "tooba","umer" , "salman"},
            //{ "mobile", "mouse","keyboard" , "pc"},
            //{ "saira baji", "iqra khan","zubda baji" , "handfree"}

            //};

            //Console.WriteLine(std_names[2,2]);

            ////jagged array 
            //Console.WriteLine("---------Jagged Array-----------");

            //int[][] list_std = new int[2][];
            //list_std[0] = new int[5] { 1, 2, 300, 4, 5 };
            //list_std[1] = new int[2] { 101, 2322 };
            //Console.WriteLine(list_std[0][1]);






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














            //Student student = new Student()
            //{
            //    Name = "Salman",
            //    Age = 18,
            //    Grade = 10
            //};

            //Console.WriteLine("Name: {0} age {1}", student.Name ,student.Age);





            //Teacher teacher = new Teacher()
            //{
            //    Name = "Jane",
            //    Age = 30,
            //    Subject = "Math"
            //};

            //Console.WriteLine("Student Information:");
            //Console.WriteLine("Name: {0}", student.Name );


            //Console.WriteLine("Teacher Information:");
            //Console.WriteLine("Name: {0}", teacher.Name);
            //Console.WriteLine("Age: {0}", teacher.Age);
            //Console.WriteLine("Subject: {0}", teacher.Subject);



            Console.ReadLine();
        }
    }
}
//class Person
//{

//    public string Name { get; set; } // property
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
















//namespace first_namespace
//{
//    class A
//    {
//        public static void display()
//        {
//            Console.WriteLine("working display method 2nd namspace");
//        }
//        public void display2()
//        {
//            Console.WriteLine("working display method 2nd namspace");
//        }
//    }
//}





//car obj = new car(20, "mursaleen");
//obj.print();



//A obj = new A();
//obj.display();
// Console.WriteLine(obj.car_color = "red");


//   employeeDetail objEmp = new employeeDetail();

// Console.WriteLine("Enter your salary increment percentage ");
//int incre = Convert.ToInt32(Console.ReadLine());
//    objEmp.employeeInfo(20, "wajahat", "wajahat@gmail.com",incre);

//marksheet objMarksheet = new marksheet();
////Console.WriteLine("Enter Maths marks");
////int m = Convert.ToInt32( Console.ReadLine());
////objMarksheet.calculate(m,66,70,50,50);
////objMarksheet.dataprint();
//objMarksheet.salary();

//class car
// {
//      string std_name;
//     int age;

//     public car(int a ,string name)
//     {
//         this.age = a;
//        this.std_name = name;
//     }
//     public void print()
//     {
//         Console.WriteLine(this.std_name +  this.age);
//     }

// }
// Access Modifies (Public , private, protected , internal)
//class car
//{
//   public string car_name;
//    string car_color;
//    int car_price;
//    int car_num;
//    protected void show()
//    {
//        this.car_color = "Red";
//        Console.WriteLine(this.car_color);
//    }
//}
//class A : car
//{
//    public void display()
//    {
//        show();
//    }
//}


//class marksheet
//{
//    int total;
//    float per;
//    public void calculate(int math , int urdu , int eng , int chem , int phy)
//    {
//        this.total = math + urdu + eng + chem + phy;
//    }
//    public void percenatge()
//    {
//        this.per = this.total * 100F / 500;
//    }
//    public void dataprint()
//    {

//        percenatge();
//        Console.WriteLine("Total Marks " + this.total);
//        Console.WriteLine("Total Percentage " + this.per);

//    }
//    public void salary()
//    {
//        int sal = 30000;
//        int aftr;
//        aftr = sal * 20 / 100;
//        Console.WriteLine(aftr + sal);
//    }

//}
//class employeeDetail
//{
//    int age, salary;
//    string name, email;

//    public void employeeInfo(int age , string name , string email, int y)
//    {
//        Console.WriteLine("Employee age: " + age);
//        Console.WriteLine("Employee name: " + name);
//        Console.WriteLine("Employee email: " + email);
//        salarydata(y);
//        Console.WriteLine( "Total Salary is: " + this.salary);
//    }
//    public void salarydata(int x)
//    {
//        int sal = 30000;
//        int aftr;
//        aftr = sal * x / 100;
//        this.salary = aftr + sal;        
//    }
//}









//class marksheet
//{
//    int maths, urdu, english, total;
//    float per;
//    public void calculateMarks(int m , int u , int e)
//    {
//        this.total = m + u + e;
//        Console.WriteLine("Total Marks " + this.total);
//    }
//    public void percentage()
//    {
//        this.per = this.total * 100F / 300 ;
//        Console.WriteLine( "Percentage :" +  Math.Round(this.per ,2));


//    }
//}

//marksheet objmarksheet = new marksheet();
//Console.WriteLine("Enter student Name");
//string std_name = Console.ReadLine();
//Console.WriteLine("========================");
//Console.WriteLine("student name is " + std_name);
//Console.WriteLine("========================");
//objmarksheet.calculateMarks(33, 77, 65);
//objmarksheet.percentage();









//int i = 0;
//while (i > 10)
//{
//    Console.WriteLine(i);
//    i++;
//}
//do
//{
//    Console.WriteLine(i);
//    i++;
//} while (i > 10);
//for(int x = 5;x <= 10;x++)
//{

//    Console.WriteLine(x + " Batch 2207F1"  );

//}


//Console.WriteLine("Enter Grade");
//string Grade = Console.ReadLine();
//switch (Grade)
//{
//    case "A":
//        Console.WriteLine("Pass");
//        break;
//    case "B":
//        Console.WriteLine("Pass");
//        break;
//    case "C":
//        Console.WriteLine("Pass");
//        break;
//    case "D":
//        Console.WriteLine("Pass");
//        break;



//    default:
//        Console.WriteLine("fAIL");
//        break;
//}


//int num1 = 20;
//if(num1 > 0 || num1 < 20)
//{
//    Console.WriteLine("true");
//}
//else
//{
//    Console.WriteLine("false");
//}



//Console.WriteLine("Enter your car name: ");
//string car_name = Console.ReadLine();

//if (car_name == "civic")
//{
//    Console.WriteLine("car name is true");

//}
//else if (car_name == "city")
//{
//    Console.WriteLine("car name is city");
//}
//else
//{
//    Console.WriteLine("false");
//}



//Console.WriteLine("Enter number 1");
//int num1 = Convert.ToInt32( Console.ReadLine());
//Console.WriteLine("Enter number 2");

//int num2 = Convert.ToInt32(Console.ReadLine());
//int result = num1 + num2;
//Console.WriteLine(result);




//Console.WriteLine( "Enter student name");
//string std_name = Console.ReadLine(); 
//Console.WriteLine("batch 2207F1 and student name is " + std_name);
