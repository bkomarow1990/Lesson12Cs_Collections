using System;
using System.Collections;
using System.Collections.Generic;
namespace SortedList_demo
{
    class Program
    {
        static void PrintKeys(SortedList s1) {
            foreach (var item in s1.Keys)
            {
                Console.WriteLine($"{item, 7}");
            }
            Console.WriteLine();
        }
        static void PrintSortedList(SortedList sl) {
            foreach (DictionaryEntry pair in sl)
            {
                Console.Write($"{pair.Key} ");
                Console.Write($"{pair.Value}\n");
            }
        }
        static void Main(string[] args)
        {
            SortedList sl = new SortedList(10) {
                { 10,"fen"},
                { 5,"five"},
                { 1,1.5},
                { 65,'A'},
                { 0,false}
            };
            sl.Add(66, 'B');
            PrintSortedList(sl);
        }
    }
}
