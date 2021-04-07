using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AdditionalTask4_ObservableCollection
{
    class FreeLanceJobs
    {
        LinkedList<Task> tasks = new LinkedList<Task>(); // Взяв LinkedList, щоб по темі вписатися
        ObservableCollection<Freelancer> freelancers = new ObservableCollection<Freelancer>();
        public FreeLanceJobs()
        {
            freelancers.CollectionChanged += this.Users_CollectionChanged;
        }
        public void AddTask(Task task)
        {
            if (task != null)
            {
                tasks?.AddLast(task);
            }
            
        }
        public void AddFreelancer(Freelancer freelancer) {
            if (freelancer != null)
            {
                freelancers?.Add(freelancer);
            }
            
        }
        public FreeLanceJobs(LinkedList<Task> tasks, ObservableCollection<Freelancer> freelancers) {
            freelancers.CollectionChanged += this.Users_CollectionChanged;
            this.tasks = tasks;
            this.freelancers = freelancers;
        }


        private void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Freelancer flncer = e.NewItems[0] as Freelancer;
                    foreach (var item in tasks)
                    {
                        if (flncer.Skill == item.RequiredSkill)
                        {
                            flncer.Info.Add(item.Name);
                            Console.WriteLine($"Updated Flancer {flncer.Name} about info for new task");
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
