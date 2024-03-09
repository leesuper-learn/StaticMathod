using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMathod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student.Change();//calling change method
                             //creating objects
            Student s1 = new Student(11, "Name 1");
            Student s2 = new Student(21, "Name 2");
            Student s3 = new Student(31, "Name 3");
            //calling display method
            s1.Display();
            s2.Display();
            s3.Display();
            Console.ReadKey();
        }
        public class Student
        {
            private int rollno;
            private string name;
            private static string college = "BBDIT";

            //constructor to initialize the variable
            public Student(int r, string n)
            {
                rollno = r;
                name = n;
            }

            //static method to change the value of static variable

            public static void Change()
            {
                college = "Test";
            }

            //method to display values
            public void Display()
            {
                Console.WriteLine(rollno + " " + name + " " + college);
            }
        }
    }
}
