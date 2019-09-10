using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade(double grade)
        {
            if(grade <= 100
               && grade >= 0)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value");
            }
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;
            //foreach (var grade in grades)
            for(var index = 0; index < grades.Count; index +=1)
            {
                if(grades[index] == 42.1)
                {
                    continue;
                }
                if(grades[index] == 55.5)
                {
                    break;
                }
                if(grades[index] == 66.6)
                {
                    goto done;
                }

                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
            }
            result.Average /= grades.Count;
            done:

            return result;
        
        }

        private List<double> grades;
        public string Name;
    }
}