using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Runbaby
{
    class Score
    {
        public int score;
        public Score(int score){
            this.score = score;
        }
        public void plus()
        {
            if (score < 100)
            {
                score += 1;
            }
            else if(score > 100){
                score += 1;
            }
            else if (score > 1000)
            {
                score += 5;
            }
            else
            {
                score += 10;
            }
        }
        public int get()
        {
            return score;
        }
    }
}
