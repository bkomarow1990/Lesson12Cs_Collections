using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace HW_AdditionalTask4_ObservableCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<Task> tasks = new LinkedList<Task>();
            tasks.AddLast(new Task("Create QT App","C++"));
            tasks.AddLast(new Task("Create Parser","C#"));
            ObservableCollection<Freelancer> freelancers = new ObservableCollection<Freelancer>();
            FreeLanceJobs freeLanceJobs = new FreeLanceJobs(tasks,freelancers);
            Console.WriteLine("Test");
            Freelancer oleg =new Freelancer("Oleg", 22, "C#");
            freeLanceJobs.AddFreelancer(oleg);
            freeLanceJobs.AddFreelancer(new Freelancer("Boris",44,"Assembler"));
            Console.WriteLine($"Oleg Info : ");
            foreach (var item in oleg.Info)
            {
                Console.WriteLine(item);
            }
        }
    }
}
