using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.WebUtilities;

namespace Mvc2AjaxFetch15.Services
{
    public interface IPlayerRepository
    {
        List<Player> GetList(int skip, int antal);
    }

    class PlayerRepository : IPlayerRepository
    {
        private static Random rand = new Random();
        private static List<Player> players;

        public PlayerRepository()
        {
            if (players == null)
            {
                players = new List<Player>();
                for (int i = 0; i < 100; i++)
                {
                    players.Add(new Player
                    {
                        Id = Guid.NewGuid(),
                        JerseyNumber = rand.Next(1,40),
                        Name = "Player " + i,
                        Position = GetPos()
                    });
                }
            }
        }

        private string GetPos()
        {
            int i = rand.Next(0, 100);
            if (i < 10) return "Goalie";
            if (i < 55) return "Defence";
            return "Forward";
        }

        public List<Player> GetList(int skip, int antal)
        {
            return players.Skip(skip).Take(antal).ToList();
        }
    }
}