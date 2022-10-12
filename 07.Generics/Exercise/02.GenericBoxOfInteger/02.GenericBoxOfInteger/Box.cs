using System;
using System.Collections.Generic;
using System.Text;
namespace _02.GenericBoxOfInteger
{
	public class Box<T>
	{
		public List<T> Items { get; set; }
		public Box()
		{
			Items = new List<T>();
		}
        public override string ToString()
        {
			StringBuilder sb = new StringBuilder();

			foreach(var x in Items)
			{
				sb.AppendLine($"{typeof(T)}: {x}"); 
			}
			return sb.ToString().Trim();
        }
    }
}

