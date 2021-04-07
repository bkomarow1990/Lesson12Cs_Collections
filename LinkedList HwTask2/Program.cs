using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace LinkedList_HwTask2
{
    class Program
    {
        class Group : IEquatable<Group>
        {
            public string Name { get; set; }
            public Group(string name)
            {
                Name = name;
            }

            public bool Equals(Group other)
            {
                if (Name == other.Name)
                {
                    return true;
                }
                return false;
            }
        }
        class Student : IEquatable<Student>
        {
            public string Name { get; set; }
            public int Age { get; set; }
            Group group= new Group("NoName");
            public Student(string name, int age, Group group)
            {
                Name = name;
                Age = age;
                this.group = group;
            }

            public bool Equals(Student other)
            {
                if (Name == other.Name && Age == other.Age && group == other.group)
                {
                    return true;
                }
                return false;
            }
            public override string ToString()
            {
                return $"Student, Name: {Name}, Age: {Age}, Group: {group.Name}"; 
            }
        }
        static void Main(string[] args)
        {
            LinkedList<Student> students = new LinkedList<Student>();
            Group g1 = new Group("G1");
            Group g2 = new Group("G2");

            students.AddLast(new Student("Oleg", 22, g1));
            students.AddLast(new Student("Ivan", 21, g1));
            students.AddFirst(new Student("Boris", 22, g2));
            students.AddFirst(new Student("Tolik", 23, g2));
            Console.WriteLine($"Student finded? : {students.Find(new Student("Oleg", 22, g1)).Value}");
            Console.WriteLine("Students in LinkedList: ");
            foreach (Student st in students)
            {
                Console.WriteLine(st);
            }
            
        }
    }
}
