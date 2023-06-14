using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace Inventory
{
    internal class Inventory
    {
        static void collect(List<string> list, string item)
        {
            bool exists = false;

            foreach (string s in list)
            {
                if (s == item)
                {
                    exists = true;
                }
            }

            if (exists)
            {
                return;
            } 

            list.Add(item);
        }

        static void drop(List<string> list, string item)
        {
            int counter = 0;

            foreach (string s in list)
            {
                if (s == item)
                {
                    list.RemoveAt(counter);
                    return;
                }

                counter++;
            }
        }

        static void renew(List<string> list, string item)
        {
            int counter = 0;

            foreach(string s in list)
            {
                if (s == item)
                {
                    list.Add(item);
                    list.RemoveAt(counter);
                    return;
                }

                counter++;
            }
        }

        static void combine(List<string> list, string item1, string item2) 
        {
            bool exists = false;
            int index = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (item1 == list[i])
                {
                    exists = true;
                    index = i;
                    break;
                }
            }

            if (exists)
            {
                list.Insert(index + 1, item2);
            }
        }

        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().
                Split(", ").ToList();

            string command = Console.ReadLine();

            while(command != "Craft!")
            {
                List<string> commands = command.Split(" - ").ToList();

                if (commands[0] == "Collect"){
                    collect(items, commands[1]);
                } else if (commands[0] == "Drop")
                {
                    drop(items, commands[1]);
                } else if (commands[0] == "Renew")
                {
                    renew(items, commands[1]);
                } else
                {
                    List<string> strings = commands[1].Split(":").ToList();

                    combine(items, strings[0], strings[1]);
                }

                command = Console.ReadLine();
            }


            for (int i = 0; i < items.Count; i++)
            {
                if (i == items.Count - 1)
                {
                    Console.Write(items[i]);
                } else
                {
                    Console.Write(items[i] + ", ");
                }
            }
        }
    }
}