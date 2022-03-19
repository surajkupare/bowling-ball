namespace BowlingBall
{
    internal class Strike : Frame
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="firstRoll"></param>
        /// <param name="secondRoll"></param>
        public Strike(int firstRoll, int secondRoll)
        {
            this.FirstRoll = firstRoll;
            this.SecondRoll = secondRoll;
        }

        /// <summary>
        /// This method is used to calculate Score of a current strike Frame.
        /// </summary>
        /// <returns></returns>
        public override int CalculateScore()
        {
            return FirstRoll + Bonus;
        }

        /// <summary>
        /// This method is used to calculate Bonus of a current strike Frame.
        /// </summary>
        /// <returns></returns>
        public override void CalculateBonus(Frame nextFrame, Frame afterNextFrame)
        {

            if (nextFrame is Strike)
                Bonus =  nextFrame.FirstRoll + (afterNextFrame == null ? 0 : afterNextFrame.FirstRoll);
            else
                Bonus =  nextFrame.FirstRoll + nextFrame.SecondRoll;
        }
    }
}
