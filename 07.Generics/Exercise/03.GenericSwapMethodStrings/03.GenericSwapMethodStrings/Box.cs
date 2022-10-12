using System;
using System.Collections.Generic;
using System.Text;
namespace _03.GenericSwapMethodStrings
{
    public class Box<T>
    {
        public List<T> Items { get; set; }
        public Box()
        {
            Items = new List<T>();
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            var a = Items[firstIndex];
            Items[firstIndex] = Items[secondIndex];
            Items[secondIndex] = a;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(var x in Items)
            {
                sb.AppendLine($"{typeof(T)}: {x}");
            }
            return sb.ToString().TrimEnd();
        }

    }
}

