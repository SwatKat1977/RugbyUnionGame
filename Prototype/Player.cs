using System;

namespace Prototype
{
    public enum PlayerPosition
    {
        /// <summary>
        /// The loose-head and tight-head props make up what is known as the
        /// front row, which refers to their position in the scrum.
        /// </summary>
        Prop,

        /// <summary>
        /// Lining up in the scrum between the two props, the hooker is one of
        /// the forwards’ key decision-makers. He or she will coordinate the
        /// timing at the scrum, and is also responsible for winning possession
        /// in the scrummage by hooking the ball back through the props' legs.
        /// </summary>
        Hooker,

        LockSecondRow,
        FlankerWingForward,
        Number8,
        ScrumHalf,
        FlyHalf,
        Wing,
        Centre,
        FullBack
    }

    public enum GameSide
    {
        LeftSide,
        RightSide
    }

    public class Player
    {
        public Position FieldPosition { get; set; }
        public PlayerPosition JerseyPosition { get; set; }

        public Player()
        {
        }
    }

    public class MatchPlayer
    {
        public Player PlayerEntry { get; private set; }
        public GameSide Side { get; private set; }

        public MatchPlayer(Player player, GameSide side)
        {
            PlayerEntry = player;
            Side = side;
        }
    }

    public class Game
    {
        MatchPlayer[] Players;

        // private
        /// List of players
    }

    public class RugbyTeam
    {
        public Player[] Team;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Player p1 = new Player();
            Player p2 = new Player();
        }
    }
}
