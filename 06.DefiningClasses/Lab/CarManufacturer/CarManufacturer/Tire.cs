using System;
namespace CarManufacturer
{
	public class Tire
	{
		private int year;
		private double pressure;
		private double sum;

		public int Year
		{
			get { return year; }
			set { this.year = value; }
		}
        public double Pressure
        {
            get { return pressure; }
            set { this.pressure = value; }
        }
		public double Sum { get; set; }

		public Tire(int year, double pressure, double sum)
		{
			this.Year = year;
			this.Pressure = pressure;
			this.Sum = sum;
		}
	}
}

