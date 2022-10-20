using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Renovator
    {
        private string name;
        private string type;
        private double rate;
        private int days;
        private bool hired;

        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }
        public string Type
        {
            get { return this.type; }
            set { type = value; }
        }
        public double Rate
        {
            get { return this.rate; }
            set { rate = value; }
        }
        public int Days
        {
            get { return this.days; }
            set { days = value; }
        }
        public bool Hired
        {
            get { return this.hired; }
            set { hired = value; }
        }

        public Renovator(string name, string type, double rate, int days)
        {
            Name = name;
            Type = type;
            Rate = rate;
            Days = days;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"-Renovator: {name}");
            sb.AppendLine($"--Specialty: {type}");
            sb.AppendLine($"--Rate per day: {rate} BGN");

            return sb.ToString().Trim();
        }
    }
}
