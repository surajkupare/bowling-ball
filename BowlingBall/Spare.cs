using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    internal class Spare : Frame
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="firstRoll"></param>
        /// <param name="secondRoll"></param>
        public Spare(int firstRoll, int secondRoll)
        {
            this.FirstRoll = firstRoll;
            this.SecondRoll = secondRoll;
        }

        /// <summary>
        /// This method is used to calculate Score of a current Spare Frame.
        /// </summary>
        /// <returns></returns>
        public override int CalculateScore()
        {
            return FirstRoll + SecondRoll +  Bonus;
        }

        /// <summary>
        /// This method is used to calculate Bonus of a current spare Frame.
        /// </summary>
        /// <returns></returns>
        public override void CalculateBonus(Frame nextFrame, Frame afterNextFrame)
        {
            Bonus = nextFrame.FirstRoll;
        }
    }
}
