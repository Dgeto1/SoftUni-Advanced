using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        private List<Animal> animals;

        private string name;
        private int capacity;

        public List<Animal> Animals
        {
            get { return animals; }
            set { animals = value; }
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

        public Zoo(string name, int capacity)
        {
            animals = new List<Animal>();
            Name = name;
            Capacity = capacity;
        }

        public string AddAnimal(Animal animal)
        {
            if(String.IsNullOrWhiteSpace(animal.Species))
            {
                return "Invalid animal species.";
            }
            if(animal.Diet != "herbivore" && animal.Diet != "carnivore")
            {
                return "Invalid animal diet.";
            }
            if(animals.Count==capacity)
            {
                return "The zoo is full.";
            }
            animals.Add(animal);

            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species)
        {
            List<Animal> al = animals.Where(x => x.Species != species).ToList();
            int count = animals.Count() - al.Count();
            animals = al;

            return count;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            return animals.Where(x => x.Diet == diet).ToList();
        }

        public Animal GetAnimalByWeight(double weight)
        {
            Animal animal = animals.FirstOrDefault(x => x.Weight == weight);

            return animal;
        }

        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            List<Animal> lenght = animals.Where(x => x.Lenght >= minimumLength && x.Lenght <= maximumLength).ToList();

            return $"There are {lenght.Count()} animals with a length between {minimumLength} and {maximumLength} meters.";
        }
    }
}
