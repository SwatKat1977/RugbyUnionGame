using System;
using System.Collections.Generic;
using Prototype.GameSimulator;

namespace Prototype
{
    public enum GameSide
    {
        LeftSide,
        RightSide
    }

    public class Player
    {
        public FieldPosition CurrentFieldPosition { get; set; }

        public Player()
        {
            CurrentFieldPosition = new FieldPosition();
        }
    }

    public class Game
    {
        List<MatchPlayer> players;

        public Game()
        {
            players = new List<MatchPlayer>();
        }

        public void AddSide(RugbyTeam team, GameSide side)
        {
            foreach(Player p in team.Team)
            {
                players.Add(new MatchPlayer(p, side));
            }
        }
    }

    public class RugbyTeam
    {
        public ValueTuple<Player, FieldPosition> Players { get; private set; }

        public RugbyTeam()
        {
            Players = new ValueTuple<Player, FieldPosition>;
        }

        public void AddPlayer(Player player, FieldPosition startingPosition)
        {
            Team.Add(player);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Player p1 = new Player();
            Player p2 = new Player();

            RugbyTeam left = new RugbyTeam();
            left.AddPlayer(p1);
            left.AddPlayer(p2);

            game.AddSide(left, GameSide.LeftSide);

            Player p3 = new Player();
            Player p4 = new Player();

            RugbyTeam right = new RugbyTeam();
            right.AddPlayer(p3);
            right.AddPlayer(p4);

            game.AddSide(right, GameSide.RightSide);
        }
    }
}
