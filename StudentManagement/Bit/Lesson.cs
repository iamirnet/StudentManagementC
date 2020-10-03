using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement.Bit
{
    class Lesson
    {
        private string name;
        private int code;
        private int unit;
        private int score;

        public string Name { get { return name; } set { name = value; } }
        public int Code { get { return code; } set { code = value; } }
        public int Unit { get { return unit; } set { unit = value; } }
        public int Score { get { return score; } set { score = value; } }

        public Lesson(string name, int code, int unit, int score)
        {
            this.name = name;
            this.code = code;
            this.unit = unit;
            this.score = score;
        }

        public Lesson()
        {
        }
    }
}
