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
            renovators = new List<Renovator>();
            Name = name;
            NeededRenovators = neededRenovators;
            Project = project;
        }

        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }
        public int NeededRenovators
        {
            get { return this.neededRenovators; }
            set { neededRenovators = value; }
        }
        public string Project
        {
            get { return this.project; }
            set { project = value; }
        }

        public int Count { get { return renovators.Count(); } }

        public string AddRenovator(Renovator renovator)
        {
            if(String.IsNullOrEmpty(renovator.Name) || String.IsNullOrEmpty(renovator.Type))
            {
                return "Invalid renovator's information.";
            }
            if(Count==neededRenovators)
            {
                return "Renovators are no more needed.";
            }
            if(renovator.Rate>350)
            {
                return "Invalid renovator's rate.";
            }

            renovators.Add(renovator);
            return $"Successfully added {renovator.Name} to the catalog.";
        }

        public bool RemoveRenovator(string name)
        {
            Renovator renovator = renovators.FirstOrDefault(x => x.Name == name);

            return renovators.Remove(renovator);
        }

        public int RemoveRenovatorBySpecialty(string type)
        {
            List<Renovator> remove = renovators.Where(x => x.Type != type).ToList();

            int count = renovators.Count() - remove.Count();
            renovators = remove;

            return count;
        }

        public Renovator HireRenovator(string name)
        {
            Renovator renovator = renovators.FirstOrDefault(x => x.Name == name);

            if(renovator!=null)
            {
                renovator.Hired = true;
            }

            return renovator;
        }

        public List<Renovator> PayRenovators(int days)
        {
            return renovators.Where(x => x.Days >= days).ToList();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            List<Renovator> unhired = renovators.Where(x => x.Hired == false).ToList();

            sb.AppendLine($"Renovators available for Project {project}:");

            foreach(var x in unhired)
            {
                sb.AppendLine(x.ToString());
            }

            return sb.ToString().Trim();
        }
    }
}
