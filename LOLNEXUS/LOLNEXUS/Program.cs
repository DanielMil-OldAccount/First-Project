using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; 
using System.Runtime.Serialization; 

namespace LOLNEXUS
{

    }
   
    class Program
    {
        static void Main(string[] args)
        {
            var json = new WebClient().DownloadString("https://na.api.pvp.net/api/lol/na/v1.4/summoner/by-name/RiotSchmick?api_key=7bbbb1ae-3d29-4d7b-b0d3-498fec6aa27e");
            Console.WriteLine(result.response.user.firstName);
        }
        /* static void Test()
        {
           
            foreach (var game in gamesResult.Games)
            {
                Console.WriteLine("Game {0}", game.GameId);
                Console.WriteLine("MapId={0} ChampionId={1} Mode={2}", game.MapId, game.ChampionId, game.GameMode);
                Console.WriteLine("Players");
                foreach (var player in game.FellowPlayers)
                {
                    Console.Write("{0}({1}) ", player.SummonerId, player.TeamId == game.TeamId ? "Teammate" : "Opponent");
                }
                Console.WriteLine("\nStats");
                foreach (var stat in game.Statistics)
                {
                    Console.Write("{0}={1}", stat.Name, stat.Value);
                }
                Console.WriteLine("\n------------------------------------------------------------");
            }
        }*/
    }

