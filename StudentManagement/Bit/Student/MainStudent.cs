using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace StudentManagement.Bit.Student
{
    class MainStudent:Controller
    {
        private string name;
        private UInt64 number;
        private string study;
        private string level;
        private List<Lesson> lessons = new List<Lesson>();
        private int scores;
        private int average;

        public string Name { get { return name; } set { name = value; } }
        public UInt64 Number { get { return number; } set { number = value; } }
        public string Study { get { return study; } set { study = value; } }
        public string Level { get { return level; } set { level = value; } }
        public List<Lesson> Lessons { get { return lessons; } set { lessons = value; } }
        public int Scores { get { return scores; } set { scores = value; } }
        public int Average { get { return average; } set { average = value; } }
    }
}
