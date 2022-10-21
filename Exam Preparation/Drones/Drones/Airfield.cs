using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        private List<Drone> drones;
        private string name;
        private int capacity;
        private double landingStrip;

        public Airfield(string name, int capacity, double landingStrip)
        {
            drones = new List<Drone>();
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
        }

        public List<Drone> Drones
        {
            get { return drones; }
            set { drones = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public double LandingStrip
        {
            get { return landingStrip; }
            set { landingStrip = value; }
        }

        public int Count
        {
            get { return drones.Count(); }
        }

        public string AddDrone(Drone drone)
        {
            if(string.IsNullOrEmpty(drone.Name) || string.IsNullOrEmpty(drone.Brand) || drone.Range<5 || drone.Range>15)
            {
                return "Invalid drone.";
            }
            if(drones.Count()==Capacity)
            {
                return "Airfield is full.";
            }

            drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }

        public bool RemoveDrone(string name)
        {
            Drone drone = drones.FirstOrDefault(x => x.Name == name);

            return drones.Remove(drone);
        }

        public int RemoveDroneByBrand(string brand)
        {
            List<Drone> dr = drones.Where(x => x.Brand != brand).ToList();
            int count = drones.Count() - dr.Count();
            drones = dr;

            return count;
        }

        public Drone FlyDrone(string name)
        {
            Drone drone = drones.FirstOrDefault(x => x.Name == name);
            if(drone!=null)
            {
                drone.Available = false;
            }

            return drone;
        }

        public List<Drone> FlyDronesByRange(int range)
        {
            return drones.Where(x => x.Range >= range).ToList();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Drones available at {Name}:");

            List<Drone> available = drones.Where(x => x.Available == true).ToList();
            foreach(Drone x in available)
            {
                sb.Append($"{x}");
            }

            return sb.ToString().Trim();
        }
    }
}
