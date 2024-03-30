using System;
using System.Collections.Generic; 


namespace mmmcspl
{
    public class student
    {
        public string StudentName { get; set; }
        public double Prelim { get; set; }
        public double Midterm { get; set; }
        public double Finals { get; set; }
    }

    public class studentpop
    {
        public List<student> students = new List<student>
        {
            new student(){StudentName = "Student A", Prelim = 78.88, Midterm = 85.00, Finals = 100.00},
            new student(){StudentName = "Student B", Prelim = 56.76, Midterm = 98.00, Finals = 100.00},
            new student(){StudentName = "Student C", Prelim = 98.00, Midterm = 87.92, Finals = 99.00},
            new student(){StudentName = "Student D", Prelim = 87.98, Midterm = 85.00, Finals = 98.00},
            new student(){StudentName = "Student E", Prelim = 89.00, Midterm = 90.15, Finals = 97.00},
            new student(){StudentName = "Student F", Prelim = 90.00, Midterm = 90.11, Finals = 89.90},


        };
    }
}