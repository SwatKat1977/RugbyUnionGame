using System;
using System.Collections.Generic;
using SimulatorEngine;

namespace Prototype
{
    public class Player
    {
        public FieldPosition CurrentFieldPosition { get; set; }

        public Player()
        {
            CurrentFieldPosition = new FieldPosition();
        }
    }

    public class RugbyTeam
    {
        public ValueTuple<Player, FieldPosition> Players { get; private set; }

        public RugbyTeam()
        {
            Players = new ValueTuple<Player, FieldPosition>();
        }

        public void AddPlayer(Player player, FieldPosition startingPosition)
        {
            // Team.Add(player);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Test teams...
            var gingerJacketsTeam = new Team(1, "Ginger Jackets");
            var irelandGuppiesTeam = new Team(2, "Ireland Guppies");

            // Test players...
            var ewanKemp = new PlayerInformation(1, "Ewan Kemp", 1);
            var tylerHenry = new PlayerInformation(2, "Tyler Henry", 1);
            var angusIrwin = new PlayerInformation(3, "Angus Irwin", 2);
            var jasperRhodes = new PlayerInformation(4, "Jasper Rhodes", 2);

            Match match = new Match();

            Player p1 = new Player();
            Player p2 = new Player();

            RugbyTeam left = new RugbyTeam();
            left.AddPlayer(p1, FieldPosition.Centre);
            left.AddPlayer(p2, FieldPosition.Hooker);

            game.AddSide(left, GameSide.LeftSide);

            Player p3 = new Player();
            Player p4 = new Player();

            RugbyTeam right = new RugbyTeam();
            right.AddPlayer(p3, FieldPosition.Prop);
            right.AddPlayer(p4, FieldPosition.ScrumHalf);

            game.AddSide(right, GameSide.RightSide);
        }
    }
}
