using System;
using System.Collections.Generic;

namespace GenericArrayCreator
{
	public class ArrayCreator
	{
		public static T[] Create<T>(int lenght, T element)
		{
			T[] array = new T[lenght];

			for(int i=0; i<array.Length; i++)
			{
				array[i] = element;
			}
			return array;
		}
	}
}

