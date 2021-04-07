using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AdditionalTask4_ObservableCollection
{
    class Freelancer
    {
        public string Name { get; set; }
        public string Skill { get; set; }
        public List<string> Info = new List<string>();
        public int Age { get; set; }
        public Freelancer(string name,int age,string skill)
        {
            Name = name;
            Age = age;
            Skill = skill;
        }

    }
}
