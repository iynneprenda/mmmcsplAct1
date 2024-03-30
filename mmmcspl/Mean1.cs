using System;
using System.Collections.Generic;
using System.Linq;

namespace mmmcspl
{
    public class Mean1
    {
        public double ComputeMeanPeriod(List<double> grades)
        {
            double total = 0;
            foreach (var grade in grades)
            {
                total += grade;
            }
            return total / grades.Count;
        }

        public double ComputeVariance(List<double> grades)
        {
            if (grades.Count == 0)
            {
                throw new InvalidOperationException("Cannot compute variance for an empty list.");
            }

            double mean = ComputeMeanPeriod(grades);
            double sumOfSquaredDifferences = 0;
            foreach (var grade in grades)
            {
                double difference = grade - mean;
                sumOfSquaredDifferences += difference * difference;
            }
            return sumOfSquaredDifferences / grades.Count;
        }

        public double ComputeStandardDeviation(List<double> grades)
        {
            return Math.Sqrt(ComputeVariance(grades));
        }

        public double ComputeRange(List<double> grades)
        {
            return grades.Max() - grades.Min();
        }

        public (double mean, double variance, double standardDeviation, double range)
            ComputeStatistics(List<double> grades)
        {
            double mean = ComputeMeanPeriod(grades);
            double variance = ComputeVariance(grades);
            double standardDeviation = ComputeStandardDeviation(grades);
            double range = ComputeRange(grades);
            return (mean, variance, standardDeviation, range);
        }

        public (double prelimMean, double prelimVariance, double prelimStandardDeviation, double prelimRange,
                double midtermMean, double midtermVariance, double midtermStandardDeviation, double midtermRange,
                double finalsMean, double finalsVariance, double finalsStandardDeviation, double finalsRange)
            ComputeStatisticsPeriod(List<student> students)
        {
            List<double> prelimGrades = students.Select(s => s.Prelim).ToList();
            List<double> midtermGrades = students.Select(s => s.Midterm).ToList();
            List<double> finalsGrades = students.Select(s => s.Finals).ToList();

            var prelimStats = ComputeStatistics(prelimGrades);
            var midtermStats = ComputeStatistics(midtermGrades);
            var finalsStats = ComputeStatistics(finalsGrades);

            return (prelimStats.mean, prelimStats.variance, prelimStats.standardDeviation, prelimStats.range,
                    midtermStats.mean, midtermStats.variance, midtermStats.standardDeviation, midtermStats.range,
                    finalsStats.mean, finalsStats.variance, finalsStats.standardDeviation, finalsStats.range);
        }
        public List<double> ComputeFinalAverages(List<student> students)
        {
            List<double> finalAverages = new List<double>();

            foreach (var student in students)
            {
               
                double finalAverage = (student.Prelim + student.Midterm + student.Finals) / 3.0;
                finalAverages.Add(finalAverage);
            }

            return finalAverages;
        }
    }
}
