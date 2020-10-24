namespace SimulationEngine
{
    public enum FieldPosition
    {
        /// <summary>
        /// The loosehead prop is positioned to the left of the hooker and his
        /// head will be on the outside of the scrum when it engages. The
        /// tighthead is to the right of the hooker with his head positioned
        /// between the opposition hooker and the opposition loosehead prop.
        /// The prop's main role is to provide stability at the scrum and
        /// support the hooker in quickly winning the ball.
        /// </summary>
        LooseHead,
        TightHead,

        /// <summary>
        /// The hooker is positioned between the two props in the scrum and
        /// generally throws the ball into the line-out. After the scrumhalf
        /// has put the ball into the scrum, the hookers use their feet to
        /// "hook" the ball back and win possession for their team. Hookers
        /// generally have a short back and long arms to aid in binding to the
        /// props. When the opposition is putting the ball into the scrum, the
        ///  hooker will either attempt to win the ball or try to disrupt the
        ///  scrum.
        /// </summary>
        Hooker,

        /// <summary>
        /// The locks form the second row. They scrummage by pushing against
        /// the front row thereby providing much of the power and are commonly
        /// known as the engine room. They are almost always the tallest
        /// players in a team and are the primary targets when the ball is
        /// thrown in at line-outs. Locks must also have good catching and
        /// tackling ability.[85] At the line-out, the locks are lifted and
        /// supported by teammates, allowing them to compete for the ball,
        /// either passing or tapping it to the scrumhalf or setting up a
        /// drive.
        /// </summary>
        Number4Lock,
        Number5Lock,

        /// <summary>
        /// The winger on the blindside often "comes off the wing" to provide
        /// an extra man in the midfield, in the same vein as a full-back. One
        /// or both wingers will usually drop back on opposition kicks to give
        /// the full-back extra options for counter-attacking.
        /// </summary>
        BlindsideFlanker,

        /// <summary>
        /// The openside flanker binds to the side of the scrum that covers the
        /// greatest area, while the blindside covers the side nearest the
        /// side-line.  They bind loosely to the side of the scrum, but still
        /// play an important role in keeping the props tight by pushing at an
        /// angle.
        /// </summary>
        OpensideFlanker,

        /// <summary>
        /// The openside flanker binds to the side of the scrum that covers the
        /// greatest area, while the blindside covers the side nearest the
        /// side-line.  They bind loosely to the side of the scrum, but still
        /// play an important role in keeping the props tight by pushing at an
        /// angle.
        /// </summary>
        Number8,

        /// <summary>
        /// The scrum-half feeds the ball into the scrum.
        /// </summary>
        ScrumHalf,

        /// <summary>
        ///  The fly-half is still often known as "outside-half" or "stand-off"
        ///  in Britain.
        /// </summary>
        FlyHalf,

        LeftWing,

        /// <summary>
        ///  The inside centre is called the "second five-eighth"
        /// </summary>
        InsideCentre,

        /// <summary>
        /// The outside centre is simply known as "centre".
        /// </summary>
        OutsideCentre,

        RightWing,

        FullBack,
    }
}
