﻿public static class BigDiceGame
{
    public static int CalculateScore(ScoringType st, int die1, int die2, int die3, int die4, int die5)
    {
        if (IsNonsense1(st))
        {
            return PairScoreCalculator.FirstPararaph(die1, die2, die3, die4, die5);
        }

        if (IsNonsense2(st))
        {
            return TwoPairScoreCalculator.SecondParagraph(die1, die2, die3, die4, die5);
        }

        if (st == ScoringType.FullHouse)
        {
            return FullHouseScoreCalculator.ThirdParagraph(die1, die2, die3, die4, die5);
        }

        if (st == ScoringType.FiveOfAKind)
        {
            return FiveOfAKindScoreCalculator.FourthParagraph(die1, die2, die3, die4, die5);
        }

        return 0;
    }

    private static bool IsNonsense2(ScoringType st)
    {
        return st == ScoringType.TwoPair;
    }

    private static bool IsNonsense1(ScoringType st)
    {
        return st == ScoringType.Pair;
    }
}