using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using StudentManagement.Bit;
using StudentManagement.Bit.Student;
using StudentManagement.Bit.Data.Students;

namespace StudentManagement
{
    class Program
    {
        public static List<MainStudent> students = new List<MainStudent>();
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            Menu menu = new Menu();
            MainStudent student1 = new Student1().get();
            MainStudent student2 = new Student2().get();
            students.AddRange(new List<MainStudent>() { student2, student1 });
            main: menu.Main();
            int ordger;
            try
            {
                ordger = int.Parse(Console.ReadLine());
                switch (ordger)
                {
                    case 1:
                        Console.Clear();
                        controller.ShowList(students);
                        break;
                    case 2:
                        Console.Clear();
                        controller.Show(students);
                        break;
                    case 3:
                        Console.Clear();
                        controller.Average(students);
                        break;
                }
                Console.ReadKey();
                goto main;
            }
            catch
            {
                Console.WriteLine("\n!!!please enter number!!!");
                goto main;
            }
        }
    }
}
