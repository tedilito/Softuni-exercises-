using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Basketball
{
    public class Team
    {
        public Team(string name, int openPositions, char group)
        {
            Name = name;
            OpenPositions = openPositions;
            Group = group;
            TeamPlayers = new List<Player>();
        }

        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }
        public List<Player> TeamPlayers { get; set; }

        public int Count => TeamPlayers.Count;
        public string AddPlayer(Player player)
        {
            if (player.Name != null && player.Position != null && player.Name != " " && player.Position != " ")
            {
                if (OpenPositions != 0)
                {
                    if (player.Rating >= 80)
                    {
                        TeamPlayers.Add(player);
                        OpenPositions--;
                        return $"Successfully added {player.Name} to the team. Remaining open positions: {OpenPositions}.";
                    }
                    else
                    {
                        return "Invalid player's rating.";
                    }
                }
                else
                {
                    return "There are no more open positions.";
                }
            }
            else
            {
                return "Invalid player's information.";
            }
        }

        public bool RemovePlayer(string name)
        {
            if (TeamPlayers.Remove(TeamPlayers.Where(x => x.Name == name).FirstOrDefault()))
            {
                OpenPositions++;
                return true;
                
            }
            else
            {
                return false;
            }
            

        }

        public int RemovePlayerByPosition(string position)
        {
            int count = TeamPlayers.RemoveAll(x => x.Position == position);
            OpenPositions += count; 
            return count;
        }

        public Player RetirePlayer(string name)
        {

            if (TeamPlayers.Any(n => n.Name == name))
            {
                Player player = TeamPlayers.Where(n => n.Name == name).FirstOrDefault();
                player.Retired = true;
                return player;

            }
            else
            {
                return null;
            }

        }

        public List<Player> AwardPlayers(int games)
        {
            return TeamPlayers.Where(pl => pl.Games >= games).ToList();
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Active players competing for Team {Name} from Group {Group}:");
            foreach (var players in TeamPlayers.Where(x => x.Retired == false))
            {
                sb.AppendLine(players.ToString());
            }
            return sb.ToString().Trim().TrimEnd();
        }




    }
}


    

