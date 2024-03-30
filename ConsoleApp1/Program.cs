using System;
using System.Collections.Generic;
using mmmcspl;
using mmmcspl.buslogic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            studentpop Studentpopulation =  new studentpop();
            var students = Studentpopulation.students; 

            Mean1 meanCalculator = new Mean1();
            Median1 medianCalculator = new Median1();
            Mode1 modeCalculator = new Mode1();

            var Mean = meanCalculator.ComputeStatisticsPeriod(students);
            var Median = medianCalculator.ComputeMedianPeriod(students);
            var Mode = modeCalculator.ComputeModePeriod(students);
            var FinalAverages = meanCalculator.ComputeFinalAverages(students);

            Console.WriteLine($"Mean of Prelim Grades: {Math.Round(Mean.prelimMean, 2)}");
            Console.WriteLine($"Mean of Midterm Grades: {Math.Round(Mean.midtermMean,2)}");
            Console.WriteLine($"Mean of Finals Grades: {Math.Round(Mean.finalsMean, 2)}");

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine($"Median of Prelim Grades: {Math.Round(Median.prelimMedian, 2)}");
            Console.WriteLine($"Median of Midterm Grades: {Math.Round(Median.midtermMedian, 2)}");
            Console.WriteLine($"Median of finals Grades: {Math.Round(Median.finalsMedian, 2)}");

            Console.WriteLine("----------------------------------------------------");

            Console.WriteLine($"Mode of the Prelim Grades: {Math.Round(Mode.prelimMode, 2)}");
            Console.WriteLine($"Mode of the Midterm Grades: {Math.Round(Mode.midtermMode, 2)}");
            Console.WriteLine($"Mode of the Finals Grades: {Math.Round(Mode.finalsMode, 2)}");

             Console.WriteLine("----------------------------------------------------");

            Console.WriteLine("--------------FINAL AVERAGE OF STUDENTS--------------");

            char studentLabel = 'A'; 
            foreach (var finalAverage in FinalAverages)
            {
                Console.WriteLine($"Student {studentLabel++}: {Math.Round(finalAverage, 2)}");
            }
        }
    }
}
