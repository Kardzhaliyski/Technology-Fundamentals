using System;
using System.Collections.Generic;
using System.Linq;

namespace OldestFamilyMember
{
    class OldestFamilyMember
    {
        static void Main(string[] args)
        {
            int peopleAdded = int.Parse(Console.ReadLine());
            Family someFamily = new Family();
            for (int i = 0; i < peopleAdded; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split();
                string name = tokens[0];
                string age = tokens[1];
                Person person = new Person(name,age);
                someFamily.AddMember(person);
            }

            Person oldesPerson = someFamily.GetOldestMember();
            Console.WriteLine($"{oldesPerson.Name} {oldesPerson.Age}");
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Person(string name, string age)
        {
            Name = name;
            Age = int.Parse(age);
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Family
    {
        public List<Person> Members { get; } = new List<Person>();

        public void AddMember(Person member)
        {
            Members.Add(member);
        }

        public Person GetOldestMember()
        {
            int oldestMemberAge = Members.Max(m => m.Age);
            var oldestMember = Members.FirstOrDefault(m => m.Age == oldestMemberAge);
            return oldestMember;
        }
    }
}
