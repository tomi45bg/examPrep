using System;
using System.Diagnostics;
using System.Linq;

namespace Hearth_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<int> numbers = text.Split("@").Select(int.Parse).ToList();
            List<bool> trueFalse = new List<bool>();

            for (int i = 0; i < numbers.Count; i++)
            {
                trueFalse.Add(false);
            }

            int index = 0;
            int lastPosition = 0;

            while (true)
            {
                string command = Console.ReadLine();

                lastPosition = index;

                if (command == "Love!")
                {
                    break;
                }

                string[] jumps = command.Split(" ").ToArray();

                int indexJump = int.Parse(jumps[1]);

                index += indexJump;
                if (index >= numbers.Count)
                {
                    index = 0;
                }

                numbers[index] -= 2;

                if (trueFalse[index] == true)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                    continue;
                }

                if (numbers[index] <= 0)
                {
                    Console.WriteLine($"Place {index} has Valentine's day.");
                    trueFalse[index] = true;
                    continue;
                }
            }

            Console.WriteLine($"Cupid's last position was {lastPosition}.");

            bool allTrue = true;
            int countFalse = 0;
            for (int i = 0; i < trueFalse.Count; i++)
            {
                if (trueFalse[i] == false) 
                {
                    allTrue = false;
                    countFalse++;
                }
            }

            if (allTrue)
            {
                Console.WriteLine("Mission was successful.");
            } else
            {
                Console.WriteLine($"Cupid has failed {countFalse} places.");
            }
        }
    }
}