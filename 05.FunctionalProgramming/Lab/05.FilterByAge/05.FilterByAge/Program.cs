using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                string[] segments = Console.ReadLine().Split(", ");
                string name = segments[0];
                int age = int.Parse(segments[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }
            string condition = Console.ReadLine();
            int ageTreshold = int.Parse(Console.ReadLine());
            if(condition=="younger")
            {
                for(int i=0; i<people.Count; i++)
                {
                    if (people[i].Age>ageTreshold)
                    {
                        people.Remove(people[i]);
                    }
                }
                string format = Console.ReadLine();
                if(format=="name age")
                {
                    foreach(var x in people)
                    {
                        Console.WriteLine($"{x.Name} - {x.Age}");
                    }
                }
                else if(format=="name")
                {
                    foreach (var x in people)
                    {
                        Console.WriteLine($"{x.Name}");
                    }
                }
                else
                {
                    foreach (var x in people)
                    {
                        Console.WriteLine($"{x.Age}");
                    }
                }
            }
            else
            {
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Age < ageTreshold)
                    {
                        people.Remove(people[i]);
                    }
                }
                string format = Console.ReadLine();
                if (format == "name age")
                {
                    foreach (var x in people)
                    {
                        Console.WriteLine($"{x.Name} - {x.Age}");
                    }
                }
                else if (format == "name")
                {
                    foreach (var x in people)
                    {
                        Console.WriteLine($"{x.Name}");
                    }
                }
                else
                {
                    foreach (var x in people)
                    {
                        Console.WriteLine($"{x.Age}");
                    }
                }
            }
        }
    }
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}

