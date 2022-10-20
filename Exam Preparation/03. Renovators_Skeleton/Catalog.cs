using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renovators
{
    public class Catalog
    {
        private List<Renovator> renovators;
        private string name;
        private int neededRenovators;
        private string project;

        public Catalog(string name, int neededRenovators, string project)
        {
            Renovators = new List<Renovator>();
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        public List<Renovator> Renovators { get; set; }
        public string Name { get; set; }
        public int NeededRenovators { get; set; }
        public string Project { get; set; }

        public int Count()
        {
            return renovators.Count();
        }

        public string AddRenovator(Renovator renovator)
        {
            if(renovator.Name == null || renovator.Type == null)
            {
                return "Invalid renovator's information.";
            }
            if(renovators.Count>=neededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if(renovator.Rate>350)
            {
                return "Invalid renovator's rate.";
            }
            else
            {
                renovators.Add(renovator);
                return $"Successfully added {renovator.Name} to the catalog.";
            }
        }
        public bool RemoveRenovator(string name)
        {
            bool isTrue = false;
            foreach(Renovator x in renovators)
            {
                if(x.Name==name)
                {
                    renovators.Remove(x);
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }
            }
            return isTrue;
        }
        public int RemoveRenovatorBySpecialty(string type)
        {
            int counter = 0;
            foreach(Renovator x in renovators)
            {
                if(x.Type==type)
                {
                    renovators.Remove(x);
                    counter++;
                }
            }
            return counter;
        }
        public Renovator HireRenovator(string name)
        {
            bool isTrue = false;
            string st = string.Empty;
            foreach(Renovator x in renovators)
            {
                if(x.Name==name)
                {
                    x.Hired = true;
                    st = x.Name;
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }
            }
            if(isTrue)
            {
                return ;
            }
            else
            {
                return null;
            }
        }

        public List<Renovator> PayRenovators(int days)
        {
            foreach(Renovator x in renovators)
            {
                if(x.Days>=days)
                {
                    PayRenovators.Ad
                }
            }
        }
    }
}
