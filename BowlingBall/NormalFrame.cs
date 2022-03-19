using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingBall
{
    internal class NormalFrame : Frame
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="firstRoll"></param>
        /// <param name="secondRoll"></param>
        public NormalFrame(int firstRoll, int secondRoll)
        {
            this.FirstRoll = firstRoll;
            this.SecondRoll = secondRoll;
        }

        /// <summary>
        /// Calculate Bonus.
        /// </summary>
        /// <param name="frame1"></param>
        /// <param name="frame2"></param>
        public override void CalculateBonus(Frame frame1, Frame frame2)
        {
            //Keep it empty for normal frame calculatation.
        }
    }
}
