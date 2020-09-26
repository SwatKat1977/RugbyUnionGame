namespace SimulationEngine
{
    public class TeamInformation
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public TeamInformation(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
