using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        private List<Player> players;
        private string name;
        private int openPositions;
        private char group;

        public Team(string name, int openPositions, char group)
        {
            players = new List<Player>();
            Name = name;
            OpenPositions = openPositions;
            Group = group;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int OpenPositions
        {
            get { return openPositions; }
            set { openPositions = value; }
        }

        public char Group
        {
            get { return group; }
            set { group = value; }
        }

        public int Count
        {
            get { return players.Count(); }
        }

        public string AddPlayer(Player player)
        {
            if(String.IsNullOrEmpty(player.Name) || String.IsNullOrEmpty(player.Position))
            {
                return "Invalid player's information.";
            }
            if(openPositions==0)
            {
                return "There are no more open positions.";
            }
            if(player.Rating< 80)
            {
                return "Invalid player's rating.";
            }
            players.Add(player);
            openPositions--;

            return $"Successfully added {player.Name} to the team. Remaining open positions: {openPositions}.";
        }

        public bool RemovePlayer(string name)
        {
            Player player = players.FirstOrDefault(x => x.Name == name);
            if(player!=null)
            {
                openPositions++;
            }
            return players.Remove(player);
        }

        public int RemovePlayerByPosition(string position)
        {
            List<Player> pl = players.Where(x => x.Position != position).ToList();
            int count = players.Count() - pl.Count();
            players = pl;
            openPositions -= count;

            return count;
        }

        public Player RetirePlayer(string name)
        {
            Player player = players.FirstOrDefault(x => x.Name == name);

            if(player!=null)
            {
                player.Retired = true;
            }
            return player;
        }

        public List<Player> AwardPlayers(int games)
        {
            return players.Where(x => x.Games >= games).ToList();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            List<Player> notRetired = players.Where(x => x.Retired == false).ToList();

            sb.AppendLine($"Active players competing for Team {group} from Group {group}:");

            foreach (var x in notRetired)
            {
                sb.AppendLine($"{x}");
            }

            return sb.ToString().Trim();
        }
    }
}
