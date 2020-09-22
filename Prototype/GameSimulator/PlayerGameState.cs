namespace SimulatorEngine
{
    public class PlayerGameState
    {
        /// <summary>Player id.</summary>
        public int PlayerId { get; private set; }

        /// <summary>Position of player during kick off.</summary>
        public FieldPosition KickoffPosition { get; set; }

        public PlayerGameState(int playerId,
                               FieldPosition initialFieldPosition)
        {
            PlayerId = playerId;
            KickoffPosition = initialFieldPosition;
        }
    }
}
