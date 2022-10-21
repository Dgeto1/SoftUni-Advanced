namespace Zoo
{
    public class Animal
    {
        private string species;
        private string diet;
        private double weight;
        private double lenght;

        public Animal(string species, string diest, double weight, double lenght)
        {
            Species = species;
            Diet = diest;
            Weight = weight;
            Lenght = lenght;
        }

        public string Species
        {
            get { return species; }
            set { species = value; }
        }
        public string Diet
        {
            get { return diet; }
            set { diet = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public double Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }

        public override string ToString()
        {
            return $"The {species} is a {diet} and weighs {weight} kg.";
        }
    }
}
