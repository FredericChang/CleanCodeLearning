
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeLearning
{
    public class Game
    {

        private int score;
        private int[] throws = new int[21];
        private int currentThrow;
        private int currentFrame;
        private bool isFirstThrow = true;

        public int Score
        {
            get { return score; }

        }
        public void Add(int pins)
        {
            throws[currentThrow++] = pins;
            score += pins;
            AdjustCurrentFrame();

        }
        
        private void AdjustCurrentFrame()
        {
            if (isFirstThrow)
            {
                isFirstThrow = false;
                currentFrame++;
            }
            else
            {
                isFirstThrow = true;
            }
        }
        
        public int CurrentFrame
        {
            get { return currentFrame; }
        }
        
        public int ScoreForFrame(int theFrame)
        {
            int ball = 0;
            int score = 0;
            for (int currentFrame = 0; currentFrame < theFrame; currentFrame++)
            {
                int firstThrow = throws[ball++];
                int secondThrow = throws[ball++];

                int frameScore = firstThrow + secondThrow;

                if (frameScore == 10)
                    score += frameScore + throws[ball++];
                else
                    score += frameScore;
            }

            return score;
        }
    }

}
