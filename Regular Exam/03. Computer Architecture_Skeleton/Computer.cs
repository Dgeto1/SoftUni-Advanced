using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ComputerArchitecture
{
    public class Computer
    {
        private List<CPU> multiprocessor;
        private string model;
        private int capacity;

        public Computer(string model, int capacity)
        {
            multiprocessor = new List<CPU>();
            Model = model;
            Capacity = capacity;
        }

        public List<CPU> Multiprocessor
        {
            get { return multiprocessor; }
            set { multiprocessor = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int Count
        {
            get { return multiprocessor.Count; }
        }

        public void Add(CPU cpu)
        {
            if(Capacity<=multiprocessor.Count)
            {
                return;
            }
            multiprocessor.Add(cpu);
            return;
        }

        public bool Remove(string brand)
        {
            CPU cPU = multiprocessor.FirstOrDefault(x => x.Brand == brand);

            return multiprocessor.Remove(cPU);
        }

        public CPU MostPowerful()
        {
            CPU cPU = multiprocessor.OrderByDescending(x => x.Frequency).First();

            return cPU;
        }

        public CPU GetCPU(string brand)
        {
            CPU cPU = multiprocessor.FirstOrDefault(x => x.Brand == brand);

            return cPU;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CPUs in the Computer {model}:");
            foreach(CPU x in multiprocessor)
            {
                sb.AppendLine($"{x}");
            }
            return sb.ToString().Trim();
        }
    }
}
