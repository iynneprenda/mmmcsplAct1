using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmmcspl.buslogic
{
    public class Median1
    {
        public double ComputeMedian(List<double> grades)
        {
            var sortedGrades = grades.OrderBy(SortAscending).ToList();

            int count = grades.Count;

            if (count % 2 == 0)
            {
                return (sortedGrades[count / 2 - 1] + sortedGrades[count / 2]) / 2.0;

            }
            else
            {
                return sortedGrades[count / 2];

            }
        }
        private double SortAscending(double grade)
        {
            return grade; 
        }
        public(double prelimMedian, double midtermMedian, double finalsMedian) ComputeMedianPeriod(List<student> students)
        {
            List<double> prelimGrades = new List<double>();
            List<double> midtermGrades = new List<double>();
            List<double> finalsGrades = new List<double> ();


            foreach (var student in students)
            {
                prelimGrades.Add(student.Prelim);
                midtermGrades.Add(student.Midterm);
                finalsGrades.Add(student.Finals);

            }

            double prelimMedian = ComputeMedian(prelimGrades);
            double midtermMedian = ComputeMedian(midtermGrades);
            double finalsMedian = ComputeMedian(finalsGrades);

            return (prelimMedian, midtermMedian, finalsMedian);
        }
    }
}
