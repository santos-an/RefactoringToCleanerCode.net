﻿public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        {
            foreach(IScoreCalculator scoreCalculator in new IScoreCalculator[] {new PairScoreCalculator(), new TwoPairScoreCalculator(), new FullHouseScoreCalculator() })
            if (scoreCalculator.IsApplicable(st))
            {
                return scoreCalculator.CalculateScore(die1, die2, die3, die4, die5);
            }
        }


        {
            IScoreCalculator scoreCalculator = new FiveOfAKindScoreCalculator();
            if (scoreCalculator.IsApplicable(st))
            {
                return new FiveOfAKindScoreCalculator().CalculateScore(die1, die2, die3, die4, die5);
            }
        }

        return 0;
    }
}