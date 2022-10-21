using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FishingNet
{
    public class Net
    {
        private List<Fish> fishes;
        private string material;
        private int capacity;

        public List<Fish> Fish
        {
            get { return fishes; }
            set { fishes = value; }
        }
        public string Material
        {
            get { return material; }
            set { material = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public Net(string material, int capacity)
        {
            fishes = new List<Fish>();
            Material = material;
            Capacity = capacity;
        }

        public int Count { get { return fishes.Count(); } }

        public string AddFish(Fish fish)
        {
            if(String.IsNullOrWhiteSpace(fish.FishType) || fish.Length<=0 || fish.Weight<=0)
            {
                return "Invalid fish.";
            }
            if(fishes.Count()==Capacity)
            {
                return "Fishing net is full.";
            }
            fishes.Add(fish);
            return $"Successfully added {fish.FishType} to the fishing net.";
        }

        public bool ReleaseFish(double weight)
        {
            Fish fish = fishes.FirstOrDefault(x => x.Weight == weight);
           
            return fishes.Remove(fish);
        }

        public Fish GetFish(string fishType)
        {
            Fish fish = fishes.FirstOrDefault(x => x.FishType == fishType);

            return fish;   
        }

        public Fish GetBiggestFish()
        {
            Fish fish = fishes.OrderByDescending(x => x.Length).First();

            return fish;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Into the {material}:");

            fishes = fishes.OrderByDescending(x => x.Length).ToList();
            foreach(Fish x in fishes)
            {
                sb.AppendLine($"{x}");
            }

            return sb.ToString().Trim();
        }
    }
}
