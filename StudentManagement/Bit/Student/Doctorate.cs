using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentManagement.Bit.Student
{
    class Doctorate:MainStudent
    {
        private string monograph;

        public string Monograph { get { return monograph; } set { monograph = value; } }
    }
}
