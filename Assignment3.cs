using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
 
    class Program
    {
        static int student(string[]n,string name)
        {
            int studentindex = Array.IndexOf(n, name);
            return studentindex;
        }
        static int top(int[] deg)
        {
            int topDegree = deg[0];
            int topindex =0;
            for(int i = 1; i < deg.Length; i++)
            {
                if (deg[i] > topDegree)
                {
                    topDegree = deg[i];
                    topindex =i;
                }
            }
            return topindex;
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number of students");
            num = int.Parse(Console.ReadLine());
            string[] name = new string[num];
            int choice;
          int[] degree = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("enter student name");
                name[i] = Console.ReadLine();
                Console.WriteLine("enter student degree");
                degree[i] = int.Parse(Console.ReadLine());
            }
           
                Console.WriteLine("                          choose an option from the following menu  ");
                Console.WriteLine("[1] Search for a student degree");
                Console.WriteLine("[2]Get top student name and degree");
                Console.WriteLine("[3] change a student name");

                Console.Write("enter your choice:");
                choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("enter student name:");
                string student_name = Console.ReadLine();
                int index = student(name, student_name);
                Console.WriteLine("student" + student_name+ "his degree is :" + degree[index]);
               
                }

            else if (choice==2)
            {
              int index = top(degree);
                Console.WriteLine("Top student name is:" + name[index] + "his degree is:" + degree[index]);
            }
            else if (choice == 3)
            { 
                Console.WriteLine("Write the old name of student you want to change");
                string old_name = Console.ReadLine();
                Console.WriteLine("enter new student name:");
                string New_name = Console.ReadLine();
                Console.WriteLine("name successfully changed into:" + New_name);
            }
            else
            {
                Console.WriteLine("not a valid choice try again");
            }
            }
        }
    
    }
