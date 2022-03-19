using System.Collections.Generic;

namespace BowlingBall
{
    public class Game
    {
        /// <summary>
        /// List of frames.
        /// </summary>
        private List<Frame> frames = new List<Frame>();

        #region[PUBLIC METHODS]

        /// <summary>
        /// This method used to add pins in a frame.
        /// </summary>
        /// <param name="firstRoll"></param>
        /// <param name="secondRoll"></param>
        public void Roll(int firstRoll, int secondRoll = 0)
        {
            FrameFactory frameFactory = new FrameFactory();
            var frame = frameFactory.CreateFrame(firstRoll, secondRoll);
            frames.Add(frame);
        }

        /// <summary>
        /// This method is used to get final score.
        /// </summary>
        /// <returns></returns>
        public int GetScore()
        {
            int score = 0;

            if (frames == null || frames.Count == 0)
                return score;

            if(frames.Count == 1)
            {
                return frames[0].CalculateScore();
            }

            int frameCount = frames.Count > 10 ? 10: frames.Count;
            for (int frameIndex = 0; frameIndex < frameCount; frameIndex++)
            {
                SetFrameBonus(frameIndex);

                score += frames[frameIndex].CalculateScore();
            }

            return score;
        }

        #endregion[PUBLIC METHODS]

        #region[PRIVATE METHODS]

        /// <summary>
        /// This is used to set Bonus to current frame.
        /// </summary>
        /// <param name="frameIndex"></param>
        private void SetFrameBonus(int frameIndex)
        {
            if ((frameIndex + 1) < frames.Count && (frameIndex + 2) < frames.Count)
                frames[frameIndex].CalculateBonus(frames[frameIndex + 1], frames[frameIndex + 2]);

            else if ((frameIndex + 1) < frames.Count)
                frames[frameIndex].CalculateBonus(frames[frameIndex + 1], null);
        }

        #endregion[PRIVATE METHODS]
    }
}
