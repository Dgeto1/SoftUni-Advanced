using System;
using System.Collections.Generic;
using System.Linq;
namespace DefiningClasses
{
	public class Family
	{
		private List<Person> people;

		public List<Person> People { get; set; }
		public Family()
		{
			people = new List<Person>();
		}
		public void AddMember(Person member)
		{
			people.Add(member);
		}
		public string GetOldestMember()
		{
			int oldestMember = people.Max(x => x.Age);
			string oldest = string.Empty;
			foreach (Person x in people)
			{
				if (oldestMember == x.Age)
				{
					oldest = x.Name;
				}
			}
			return $"{oldest} {oldestMember}";
		}
	}
}

