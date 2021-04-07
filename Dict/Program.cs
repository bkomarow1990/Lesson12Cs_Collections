using System;
using System.Collections.Generic;
using System.Collections;

namespace Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> peoples = new()
            { 
                [111] = "Olena",
                [55] = "Ivan",
                [77] = "Olia"
            };
            peoples.Add(100, "Dmytro");
            foreach (var item in peoples)
            {
                Console.Write($"{item.Key} {item.Value}\n");
            }
            SortedDictionary<int, string> peopleS = new SortedDictionary<int, string>(peoples);
            peopleS.Add(22, "Oleg");
            peopleS.Add(33, "Marina");
            Console.WriteLine("Sorted people by ID");
        }
    }
}
