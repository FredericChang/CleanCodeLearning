﻿
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

        public int Score
        {
            get { return score; }

        }
        public void Add(int pins)
        {
            throws[currentThrow++] = pins;
            score += pins;

        }
        
        public int ScoreForFrame(int theFrame)
        {
            int ball = 0;
            int score = 0;
            for (int currentFrame = 0; currentFrame < theFrame; currentFrame++)
            {
                int firstThrow = throws[ball++];
                int secondThrow = throws[ball++];

                score += firstThrow + secondThrow;
            }
            return score;
        }
    }

}
