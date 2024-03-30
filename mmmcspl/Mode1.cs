using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mmmcspl.buslogic
{
    public class Mode1
    {
        public double ComputeMode(List<double> grades)
        {
            {
                if (grades.Count == 0)
                {
                    throw new InvalidOperationException("Cannot compute mode for an empty list.");
                }

                var frequencyMap = grades.GroupBy(x => x)
                                         .ToDictionary(g => g.Key, g => g.Count());

                double mode = frequencyMap.OrderByDescending(kv => kv.Value)
                                           .First()
                                           .Key;

                return mode;
            }
        }
        public (double prelimMode, double midtermMode, double finalsMode) ComputeModePeriod(List<student> students)
        {
            var prelimGrades = students.Select(s => s.Prelim).ToList();
            var midtermGrades = students.Select(s => s.Midterm).ToList();
            var finalsGrades = students.Select(s => s.Finals).ToList();

            double prelimMode = ComputeMode(prelimGrades);
            double midtermMode = ComputeMode(midtermGrades);
            double finalsMode = ComputeMode(finalsGrades);

            return (prelimMode, midtermMode, finalsMode);
        }
    }
}
