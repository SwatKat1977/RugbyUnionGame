namespace Prototype
{
    namespace GameSimulator
    {
        public class MatchPlayer
        {
            public Player PlayerEntry { get; private set; }
            public GameSide Side { get; private set; }

            public Position FieldPosition { get; set; }

            public MatchPlayer(Player player, GameSide side, Position position)
            {
                PlayerEntry = player;
                Side = side;
                FieldPosition = position;
            }
        }
    }
}
