﻿public static class BigDiceGame 
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        {
            IScore score = new PairScore();
            if (score.IsSomeCondition(st))
            {
                return score.Evaluate(die1, die2, die3, die4, die5);
            }
        }

        {
            TwoPairScore score = new TwoPairScore();
            if (score.IsSomeCondition(st))
            {
                return score.Evaluate(die1, die2, die3, die4, die5);
            }
        }
        {
            FullHouseScore score = new FullHouseScore();
            if (score.IsSomeCondition(st))
            {
                return score.Evaluate(die1, die2, die3, die4, die5);
            }
        }
        {
            FiveOfKindScore score = new FiveOfKindScore();
            if (score.IsSomeCondition(st))
            {
                return score.Evaluate(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}