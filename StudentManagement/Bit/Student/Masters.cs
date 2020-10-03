using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentManagement.Bit;

namespace StudentManagement.Bit.Student
{
    class Masters:MainStudent
    {
        private string thesis;

        public string Thesis { get { return thesis; } set { thesis = value; } }
    }
}
