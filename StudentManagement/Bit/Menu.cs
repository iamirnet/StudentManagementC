using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace StudentManagement.Bit
{
    class Menu:Controller
    {
        private ArrayList main = new ArrayList() { "Student List", "Student Info", "View Count & Average All Student" };
        private ArrayList student = new ArrayList() { "Sort List", "Add Student", "Edit Student", "Delete Student", "Student Info" };
        private ArrayList editStudent = new ArrayList() { "ID", "Full Name", "Study", "Level", "Lessons" };
        private ArrayList lessons = new ArrayList() { "Add Lesson", "Edit Lesson" };
        private ArrayList editLesson = new ArrayList() { "Name", "Code", "Unit", "Score" };
        private ArrayList sort = new ArrayList() { "ID", "Name", "Study", "Level", "Scores", "Average" };
        private ArrayList average = new ArrayList() { "All Student", "Study", "Level" };
        private ArrayList level = new ArrayList() { "Bachelor", "Masters", "Doctorate" };
        private ArrayList study = new ArrayList() { "Computer" };
        public void Main()
        {
            Console.Clear();
            Console.WriteLine("Please select a section: ");
            foreach (var item in this.main)
            {
                Console.WriteLine("     {0}.{1}", this.main.IndexOf(item) + 1, item);
            }
        }

        public void Student()
        {
            Console.WriteLine("Please select a action: ");
            foreach (var item in this.student)
            {
                Console.WriteLine("     {0}.{1}", this.student.IndexOf(item) + 1, item);
            }
        }

        public void Sort()
        {
            Console.WriteLine("Please select sort by: ");
            foreach (var item in this.sort)
            {
                Console.WriteLine("     {0}.{1}", this.sort.IndexOf(item) + 1, item);
            }
        }

        public void Average()
        {
            Console.WriteLine("Please select By: ");
            foreach (var item in this.average)
            {
                Console.WriteLine("     {0}.{1}", this.average.IndexOf(item) + 1, item);
            }
        }

        public void Study()
        {
            Console.WriteLine("Please select By: ");
            foreach (var item in this.study)
            {
                Console.WriteLine("     {0}.{1}", this.study.IndexOf(item) + 1, item);
            }
        }

        public void Level()
        {
            Console.WriteLine("Please select By: ");
            foreach (var item in this.level)
            {
                Console.WriteLine("     {0}.{1}", this.level.IndexOf(item) + 1, item);
            }
        }

        public void EditStudent()
        {
            Console.WriteLine("Please select action edit: ");
            foreach (var item in this.editStudent)
            {
                Console.WriteLine("     {0}.{1}", this.editStudent.IndexOf(item) + 1, item);
            }
        }

        public void Lessons()
        {
            Console.WriteLine("Please select action edit: ");
            foreach (var item in this.lessons)
            {
                Console.WriteLine("     {0}.{1}", this.lessons.IndexOf(item) + 1, item);
            }
        }

        public void EditLesson()
        {
            Console.WriteLine("Please select action edit: ");
            foreach (var item in this.editLesson)
            {
                Console.WriteLine("     {0}.{1}", this.editLesson.IndexOf(item) + 1, item);
            }
        }

    }
}
