using System;
namespace DefiningClasses
{
	public class Person
	{
		private string name;
		private int age;

		public string Name
		{
			get { return name; }
			set { this.name = value; }
		}
		public int Age
		{
			get { return age; }
			set { this.age = value; }
		}
		public Person()
		{
			Name = "No name";
			Age = 1;
		}
		public Person(int age)
		{
			Name = "No name";
			this.Age = age;
		}
		public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}
	}
}

