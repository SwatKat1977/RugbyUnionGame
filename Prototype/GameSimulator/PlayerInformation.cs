namespace SimulationEngine
{
    public class PlayerInformation
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public int TeamId { get; private set; }

        public PlayerInformation(int id, string name, int team = -1)
        {
            Id = id;
            Name = name;
            TeamId = team;
        }
    }
}
