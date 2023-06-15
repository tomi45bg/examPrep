using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstCount = int.Parse(Console.ReadLine());
            int secondCount = int.Parse(Console.ReadLine());
            int thirdCount = int.Parse(Console.ReadLine());

            int studentsCount = int.Parse(Console.ReadLine());
            int hoursNeeded = 0;

            bool first = true;

            int perHour = firstCount + secondCount + thirdCount;

            while (studentsCount > 0)
            {
                if (hoursNeeded % 4 == 0 && !first)
                {
                    hoursNeeded++;
                    continue;
                }

                studentsCount -= perHour;
                hoursNeeded++;
                first = false;
            }

            Console.WriteLine($"Time needed: {hoursNeeded}h.");
        }
    }
}