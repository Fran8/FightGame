using System;
using System.Collections.Generic;
using System.Text;

namespace FightGame
{
    public interface IPlayerService
    {
        List<Player> GetPlayers();
        {
        return null;
        }

        Players = new List<Player>
            {
                
                new Player
                {
                    Id = ++Game.LastId,
                    Name = "Cat Woman",
                    Gender = Gender.Female,
                    Lives = DefaultLives,
                    Power = DefaultPower
    },
                new Player
                {
                    Id = ++Game.LastId,
                    Name = "Lobezno",
                    Gender = Gender.Male,
                    Lives = DefaultLives,
                    Power = DefaultPower
},
                new Player
                {
                    Id = ++Game.LastId,
                    Name = "Wonder Woman",
                    Gender = Gender.Female,
                    Lives = DefaultLives,
                    Power = DefaultPower
                },
                new Player
                {
                    Id = ++Game.LastId,
                    Name = "Batman",
                    Gender = Gender.Male,
                    Lives = DefaultLives,
                    Power = DefaultPower
                },
            };

    }

    public class CustomPlayerService : IPlayerService
    {
        public List<Player> GetPlayers()
        {
            throw new NotImplementedException();
        }
    }
}
