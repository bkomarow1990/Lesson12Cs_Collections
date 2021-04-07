using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AdditionalTask4_ObservableCollection
{
    class Task
    {
        public string Name { get; set; }
        public string RequiredSkill { get; set; }
        public Task(string name, string skill)
        {
            Name = name;
            RequiredSkill = skill;
        }
    }
}
