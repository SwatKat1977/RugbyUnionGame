using System.Collections.Generic;

namespace SimulationEngine
{
    public enum PlayerStartState
    {
        StartingGame,
        Substitute
    }

    public class MatchDayTeam
    {
        public class InitialPlayerState
        {
            public FieldPosition InitialFieldPosition { get; set; }
            public PlayerStartState StartState { get; set; }
        }

        public Dictionary<int, InitialPlayerState> Players { get; private set; }

        public MatchDayTeam()
        {
            Players = new Dictionary<int, InitialPlayerState>();
        }

        public void AddPlayer(int playerId,
                              FieldPosition startingPosition)
        {
            var initState = new InitialPlayerState
            {
                StartState = PlayerStartState.StartingGame,
                InitialFieldPosition = startingPosition
            };

            Players[playerId] = initState;
        }
    }
}
