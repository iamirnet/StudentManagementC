﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentManagement.Bit.Student;
using System.Collections;

namespace StudentManagement.Bit.Data.Students
{
    class Student1
    {
        public MainStudent get()
        {
            Bachelor student = new Bachelor();
            student.Name = "Ali Ahmadi";
            student.Number = 98060100001;
            student.Study = "Computer";
            student.Level = "Bachelor";
            student.Lessons = new List<Lesson>() { 
                new Lesson("Math", 20124, 2, 15),
                new Lesson("Job", 20125, 2, 14),
                new Lesson("Sport", 20126, 2, 18),
                new Lesson("Literature", 20127, 2, 18),
                new Lesson("Programming", 20128, 3, 15),
                new Lesson("Network", 20129, 2, 18),
                new Lesson("System", 20130, 2, 18),
            };

            foreach (Lesson lesson in student.Lessons)
            {
                student.Scores += lesson.Score;
            }
            student.Average = student.Scores / student.Lessons.Count;
            student.Project = "Test";
            return student;
        }
    }
}
