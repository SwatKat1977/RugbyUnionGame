namespace SimulationEngine
{
    public class PlayerGameState
    {
        /// <summary>Player id.</summary>
        public int PlayerId { get; private set; }

        /// <summary>Position of player during kick off.</summary>
        public FieldPosition KickoffPosition { get; set; }

        public int Heading { get; set; }

        public Position CurrentPosition { get; set; }

        public PlayerGameState(int playerId,
                               FieldPosition initialFieldPosition,
                               int heading)
        {
            PlayerId = playerId;
            KickoffPosition = initialFieldPosition;
            Heading = heading;
            CurrentPosition = new Position(0, 0);
        }
    }
}
