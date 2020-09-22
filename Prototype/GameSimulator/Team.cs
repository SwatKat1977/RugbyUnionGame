namespace Prototype.GameSimulator
{
    public class Team
    {
        public string Id { get; private set; }

        public string Name { get; private set; }

        public Team(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
