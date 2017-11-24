using FightGame.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FightGame
{
    public class StarWarsPlayerService : IPlayerService
    {
        private static List<Player> _players = new List<Player>();

        private const string ApiUrl = "https://swapi.co/api/people/";

        public Player AddPlayer(Player player)
        {
            player.Id = _players.Max(x => x.Id) + 1;
            _players.Add(player);

            return player;
        }

        private const string ApiUrl = "https://swapi.co/api/people/";

        public List<Player> GetPlayers()
        {
            var httpClient = new HttpClient();
            Task<string> task = httpClient.GetStringAsync(ApiUrl);

            //forma 1 de recuperar valor
                //Task.Run(async() =>
                //{
                //    string result = await task;
                //});

            // forma 2 de recuperar valor
            string result = task.Result;
            StarWarsPeople people = JsonConvert.DeserializeObject<StarWarsPeople>(result);

            //Convertir List<Person> en nuestro List<Player>
            //var players = new List<Player>();
            //foreach(var person in people.results)
            //{
            //    players.Add(new Player
            //    {
            //        Id = ++Game.LastId,
            //        Name = person.name,
            //        Gender = person.gender == "male" ? Gender.Male : Gender.Female,
            //        Lives = Game.DefaultLives,
            //        Power = Game.DefaultPower
                    
            //    });
                   
            //}

            // 2: Convertir List<Person> en nuestro List<Player> con LINQ
            var players = people.results.Select(person => new Player

            {
                Id = ++GameModel.LastId,
                Name = person.PlayerName,
                Gender = person.PlayerGender == "male" ? Gender.Male : Gender.Female,
                Lives = GameModel.DefaultLives,
                Power = GameModel.DefaultPower

            });

            return players.ToList();
        }
    }
}
