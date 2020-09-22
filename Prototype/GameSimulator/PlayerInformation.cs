namespace Prototype.GameSimulator
{
    public class PlayerInformation
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public string TeamId { get; private set; }


        public PlayerInformation(string id, string name, string team = null)
        {
            Id = id;
            Name = name;
            TeamId = team;
        }
    }
}
