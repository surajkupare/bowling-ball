namespace BowlingBall
{
    public abstract class Frame
    {
        /// <summary>
        /// First Roll in a Frame.
        /// </summary>
        public int FirstRoll { get; set; }

        /// <summary>
        /// Second Roll in a Frame.
        /// </summary>
        public int SecondRoll { get; set; }

        /// <summary>
        /// Bonus in a Frame.
        /// </summary>
        public virtual int Bonus { get; set; }

        /// <summary>
        /// This method is used to calculate Score of a current Frame.
        /// </summary>
        /// <returns></returns>
        public virtual int CalculateScore()
        {
            return FirstRoll + SecondRoll;
        }

        /// <summary>
        /// This method is used to calculate Bonus of a current Frame.
        /// </summary>
        /// <returns></returns>
        public abstract void CalculateBonus(Frame frame1, Frame frame2);

    }
}
