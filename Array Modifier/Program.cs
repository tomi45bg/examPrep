using System;
using System.Diagnostics;
using System.Linq;

namespace Array_Modifier
{
    internal class Program
    {
        static void swap(int x, int y, int[] arr)
        {
            int z = arr[x];
            arr[x] = arr[y];
            arr[y] = z;
        }

        static void multiply(int x, int y, int[] arr)
        {
            arr[x] *= arr[y];
        }

        static void decrease(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] -= 1;
            }
        }

        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().
                Split(" ").Select(int.Parse).ToArray();

            string command = Console.ReadLine();

            while(command != "end")
            {
                string[] function = command.Split(" ").ToArray();

                if (function[0] == "swap")
                {
                    swap(int.Parse(function[1]), int.Parse(function[2]), array);
                } else if (function[0] == "multiply")
                {
                    multiply(int.Parse(function[1]), int.Parse(function[2]), array);
                } else
                {
                    decrease(array);
                }

                command = Console.ReadLine();
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Console.Write(array[i]);
                } else
                {
                    Console.Write(array[i] + ", ");
                }
            }
        }
    }
}