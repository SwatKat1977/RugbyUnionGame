namespace SimulationEngine
{
    public enum FieldPosition
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
}
