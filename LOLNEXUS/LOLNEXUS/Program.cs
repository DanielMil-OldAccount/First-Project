using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net; 
using System.Runtime.Serialization.Json;

namespace LOLNEXUS
{

    }
   
    class Program
    {
        static void Main(string[] args)
        {
        }
         static void Test()
        {
            var gamesResult = EF.RiotApi.Client.RiotWeb.API.Game.GetGamesBySummoner(32144);
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
        }
    }
}
