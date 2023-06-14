using System;
using System.Diagnostics;
using System.Linq;

namespace Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countStudents = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int bonus = int.Parse(Console.ReadLine());

            double maxPoints = 0;
            int maxLectures = 0;

            for (int i = 0; i < countStudents; i++)
            {
                int points = int.Parse(Console.ReadLine());

                //{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})

                double bonusStudent = (points * 1.0/lecturesCount) * (5 + bonus);

                if (bonusStudent > maxPoints)
                {
                    maxPoints = bonusStudent;
                    maxLectures = points;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxPoints)}.");
            Console.WriteLine($"The student has attended {maxLectures} lectures.");
        }
    }
}