using System;
namespace CarManufacturer
{
	public class Car
	{
		private string make;
		private string made;
		private int year;

		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }
		public Car(string make, string model, int year)
		{
			this.Make = make;
			this.Model = model;
			this.Year = year;
		}
	}
}

