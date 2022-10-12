using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodStrings
{
    public class Box<T> where T: IComparable
    {
        public List<T> Items { get; set; }
        public Box()
        {
            Items = new List<T>();
        }
        public int Count(T element)
        {
            int counter = 0;
            foreach(var x in Items)
            {
                if (x.CompareTo(element) == 1)
                    counter++;
            }
            return counter;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var x in Items)
            {
                sb.AppendLine($"{typeof(T)}: {x}");
            }
            return sb.ToString().TrimEnd();
        }

    }
}

