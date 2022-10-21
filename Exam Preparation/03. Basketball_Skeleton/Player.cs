using System;
using System.Text;

namespace Basketball
{
    public class Player
    {
        private string name;
        private string position;
        private double rating;
        private int games;
        private bool retired;

        public Player(string name, string position, double rating, int games)
        {
            Name = name;
            Position = position;
            Rating = rating;
            Games = games;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public double Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public int Games
        {
            get { return games; }
            set { games = value; }
        }
        public bool Retired
        {
            get { return retired; }
            set { retired = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"-Player: {name}");
            sb.AppendLine($"--Position: {position}");
            sb.AppendLine($"--Rating: {rating}");
            sb.AppendLine($"--Games played: {games}");

            return sb.ToString().Trim();
        }
    }
}
