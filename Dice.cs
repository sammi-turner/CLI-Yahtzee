using System;

static class Dice
{
    // Roll the dice

    public static void Default(int[] a)
    {
        a[0] = 5;
        a[1] = 0;
        a[2] = 0;
        a[3] = 0;
        a[4] = 0;
        a[5] = 0;
        a[6] = 0;
    }

    public static void Count(int[] a)
    {
        while (a[0] > 0)
        {
            int rando;
            Random rd = new Random();
            rando = rd.Next(1, 7);

            a[0]--;
            switch (rando)
            {
                case 1:
                    a[1]++;
                    break;
                case 2:
                    a[2]++;
                    break;
                case 3:
                    a[3]++;
                    break;
                case 4:
                    a[4]++;
                    break;
                case 5:
                    a[5]++;
                    break;
                case 6:
                    a[6]++;
                    break;
            };
        };
    }

    // Second round or not?

    public static bool SecondRound(int[] a)
    {
        return (a[0] > 0);
    }

    // Displays dice held

    public static void Held(int[] a)
    {
        Console.Write($"\n     DICE HELD\n\n     {a[1]} 1s, {a[2]} 2s, {a[3]} 3s, {a[4]} 4s, {a[5]} 5s, {a[6]} 6s.\n\n");
    }

    // Three of a kind score function

    public static int ThreeOfAKind(int[] a)
    {
        int value = 0;
        if (a[1] > 2 || a[2] > 2 || a[3] > 2 || a[4] > 2 || a[5] > 2 || a[6] > 2)
        {
            value = a[1] + (a[2] * 2) + (a[3] * 3) + (a[4] * 4) + (a[5] * 5) + (a[6] * 6);
        };
        return value;
    }

    // Four of a kind score function

    public static int FourOfAKind(int[] a)
    {
        int value = 0;
        if (a[1] > 3 || a[2] > 3 || a[3] > 3 || a[4] > 3 || a[5] > 3 || a[6] > 3)
        {
            value = a[1] + (a[2] * 2) + (a[3] * 3) + (a[4] * 4) + (a[5] * 5) + (a[6] * 6);
        };
        return value;
    }

    // Full house score function

    public static int FullHouse(int[] a)
    {
        int value = 0;
        bool tripleTest = false;
        bool pairTest = false;

        if (a[1] == 3 || a[2] == 3 || a[3] == 3 || a[4] == 3 || a[5] == 3 || a[6] == 3)
        {
            tripleTest = true;
        };

        if (a[1] == 2 || a[2] == 2 || a[3] == 2 || a[4] == 2 || a[5] == 2 || a[6] == 2)
        {
            pairTest = true;
        };

        if (tripleTest && pairTest)
        {
            value = 25;
        };

        if (a[1] == 5 || a[2] == 5 || a[3] == 5 || a[4] == 5 || a[5] == 5 || a[6] == 5)
        {
            value = 25;
        };

        return value;
    }

    // Small straight score function

    public static int SmallStraight(int[] a)
    {
        int value = 0;

        if (a[1] > 0 && a[2] > 0 && a[3] > 0 && a[4] > 0)
        {
            value = 30;
        };

        if (a[2] > 0 && a[3] > 0 && a[4] > 0 && a[5] > 0)
        {
            value = 30;
        };

        if (a[3] > 0 && a[4] > 0 && a[5] > 0 && a[6] > 0)
        {
            value = 30;
        };

        return value;
    }

    // Large straight score function

    public static int LargeStraight(int[] a)
    {
        int value = 0;

        if (a[1] > 0 && a[2] > 0 && a[3] > 0 && a[4] > 0 && a[5] > 0)
        {
            value = 40;
        };

        if (a[2] > 0 && a[3] > 0 && a[4] > 0 && a[5] > 0 && a[6] > 0)
        {
            value = 40;
        };
        return value;
    }

    // The total of all dice

    public static int Chance(int[] a)
    {
        return a[1] + (a[2] * 2) + (a[3] * 3) + (a[4] * 4) + (a[5] * 5) + (a[6] * 6);
    }

    // Yahtzee score function

    public static int Yahtzee(int[] a)
    {
        int value = 0;
        if (a[1] == 5 || a[2] == 5 || a[3] == 5 || a[4] == 5 || a[5] == 5 || a[6] == 5)
        {
            value = 50;
        };
        return value;
    }
}
