﻿public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        {
            if (new PairScoreCalculator().IsSupported(st))
            {
                return new PairScoreCalculator().Calculate(die1, die2, die3, die4, die5);
            }
        }

        {
            if (new TwoPairScoreCalculator().IsSupported(st))
            {
                return new TwoPairScoreCalculator().Calculate(die1, die2, die3, die4, die5);
            }
        }

        {
            if (new FullHouseScoreCalculator().IsSupported(st))
            {
                return new FullHouseScoreCalculator().Calculate(die1, die2, die3, die4, die5);
            }
        }

        {
            if (FiveOfAKindScoreCalculator.IsSupported(st))
            {
                return FiveOfAKindScoreCalculator.Calculate(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}