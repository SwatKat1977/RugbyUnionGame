using System;
using SimulationEngine;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test teams...
            var gingerJacketsTeam = new TeamInformation(1, "Ginger Jackets");
            var irelandGuppiesTeam = new TeamInformation(2, "Ireland Guppies");

            // Test players...
            var ewanKemp = new PlayerInformation(1, "Ewan Kemp", 1);
            var tylerHenry = new PlayerInformation(2, "Tyler Henry", 1);
            var angusIrwin = new PlayerInformation(3, "Angus Irwin", 2);
            var jasperRhodes = new PlayerInformation(4, "Jasper Rhodes", 2);

            Match match = new Match();

            MatchDayTeam left = new MatchDayTeam();
            left.AddPlayer(1, FieldPosition.Centre);
            left.AddPlayer(2, FieldPosition.Hooker);

            match.AddSide(left, GameSide.LeftSide);

            MatchDayTeam right = new MatchDayTeam();
            right.AddPlayer(3, FieldPosition.Prop);
            right.AddPlayer(4, FieldPosition.ScrumHalf);

            match.AddSide(right, GameSide.RightSide);

            match.Test();
            match.Test();
        }
    }
}
