using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace HW_Task1
{
   

    class WorkWithWords
    {
        private Dictionary<string, int> words = new Dictionary<string, int>();
        public void SetText(string text)
        {
            this.words?.Clear();
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                string res = word;
                res = res.Trim(',', '.', '!', '?');
                if (String.IsNullOrEmpty( res))
                {
                    break;
                }
                if (this.words.ContainsKey(res))
                {
                    int value = 1;
                    this.words.TryGetValue(word, out value);
                    this.words[res] = ++value;
                }
                else
                {
                    this.words.Add(res, 1);
                }
            }
            

        }
        public void Print()
        {
            int i = 1;
            Console.WriteLine($"{"Слово", 20} {"Кількість", 30}");
            foreach (var item in words)
            {
                Console.WriteLine($"{i, 0 }. {item.Key, 20} {item.Value,  30}");
                ++i;
            }
            Console.WriteLine($"Всього {words.Count} слів, з них { ( words.Where(x=>x.Value==1).ToArray().Length)} унікальні");
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            WorkWithWords workWithWords = new WorkWithWords();
            workWithWords.SetText("Ось будинок, який побудував Джек. А це пшениця, Яка в темній комірці зберігається У будинку, Який побудував Джек.А це весела птиця - синиця, Яка часто краде пшеницю, Яка в темній комірці зберігається У будинку, Який побудував Джек.");
            workWithWords.Print();
        }
    }
}
