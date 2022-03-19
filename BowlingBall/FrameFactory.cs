namespace BowlingBall
{
    internal class FrameFactory //make static and make changes
    {
        /// <summary>
        /// This method is used to determine which instance needs to get instantiated.
        /// </summary>
        /// <param name="firstRoll"></param>
        /// <param name="secondRoll"></param>
        /// <returns></returns>
        public Frame CreateFrame(int firstRoll, int secondRoll)
        {
            if (firstRoll == 10)
                return new Strike(firstRoll, secondRoll);

            else if(firstRoll + secondRoll == 10)
                return new Spare(firstRoll, secondRoll);

            return new NormalFrame(firstRoll, secondRoll);
        }
    }
}
