namespace Prototype
{
    namespace GameSimulator
    {
        public class MatchPlayer
        {
            /// <summary>Player details.</summary>
            public Player PlayerDetails { get; private set; }

            /// <summary>Position of player during kick off.</summary>
            public FieldPosition KickoffPosition { get; set; }

            /// <summary>Current position of player during match.</summary>
            public Position CurrentPosition { get; set; }

            public MatchPlayer(Player player,
                FieldPosition initialFieldPosition)
            {
                PlayerDetails = player;
                KickoffPosition = initialFieldPosition;
                CurrentPosition = new
            }
        }
    }
}
