using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            List<Person> people = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for(int i =0; i<n; i++)
            {
                string[] segments = Console.ReadLine().Split();
                Person person = new Person(segments[0], int.Parse(segments[1]));
                family.AddMember(person);
                people.Add(person);
            }
            people = people.Where(x => x.Age > 30).ToList();
            people = people.OrderBy(x => x.Name).ToList();
            foreach(Person x in people)
            {
                Console.WriteLine(x.Name +" - " + x.Age);
            }
        }
    }
}

