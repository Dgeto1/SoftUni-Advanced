﻿using System;
namespace CarManufacturer
{
	public class Engine
	{
		private int horsePower;
		private double cubicCapacity;

		public int HorsePower
		{
			get { return horsePower; }
			set { this.horsePower = value; }
		}
		public double CubicCapacity
		{
			get { return cubicCapacity; }
			set { this.cubicCapacity = value; }
		}
		public Engine(int horsePower, double cubicCapacity)
		{
			this.HorsePower = horsePower;
			this.cubicCapacity = cubicCapacity;
		}
	}
}

