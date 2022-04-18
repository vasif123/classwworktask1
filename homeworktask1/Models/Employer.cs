using System;
using System.Collections.Generic;
using System.Text;

namespace homeworktask1.Models
{
    class Employer
    {
        private static int id;
        public int No;
        public string Fullname;
        public int Salary;
        public string Position;

        public Employer(string fullname,int salary,string position)
        {
            No = id;
            id++;
            Fullname = fullname;
            Salary = salary;
            Position = position;
        }
    }
}
