using static System.Console;
using System.IO;

public class Score
{
    public int s1, s2, s3, s4, s5, s6, TK, FK, FH, SS, LS, CH, YA;
    public Score()
    {
        s1 = -1; s2 = -1; s3 = -1; s4 = -1; s5 = -1; s6 = -1;
        TK = -1; FK = -1; FH = -1; SS = -1; LS = -1; CH = -1; YA = -1;
    }

    static bool IsDigit(char arg)
    {
        int value = arg;
        return (value > 47 || value < 58);
    }

    public void PlayerReRolls(int[] a)
    {
        int num = -1;
        char choice;

        for (int i = 1; i < 7; i++)
        {
            if (a[i] > 0)
            {
                while (num < 0 || num > a[i])
                {
                    Card();
                    Dice.Held(a);
                    Write($"     You have {a[0]} re-rolls\n\n");
                    Write($"     How many {i}s do you want to re-roll? ");
                    choice = ReadKey().KeyChar;
                    if (IsDigit(choice))
                    {
                        num = choice - '0';
                    }
                }
                a[0] += num;
                a[i] -= num;
                num = -1;
            };
        }
    }

    // Which score box?

    public void Selection(int[] a)
    {
        char choice;
        bool exitLoop = false;

        while (exitLoop == false)
        {
            Card();
            Dice.Held(a);
            WriteLine("     Which scorebox? ");
            choice = ReadKey().KeyChar;

            if ((choice == 'm') && (s1 == -1))
            {
                s1 = a[1];
                exitLoop = true;
            };

            if ((choice == 'n') && (s2 == -1))
            {
                s2 = (a[2] * 2);
                exitLoop = true;
            };

            if ((choice == 'o') && (s3 == -1))
            {
                s3 = (a[3] * 3);
                exitLoop = true;
            };

            if ((choice == 'p') && (s4 == -1))
            {
                s4 = (a[4] * 4);
                exitLoop = true;
            };

            if ((choice == 'q') && (s5 == -1))
            {
                s5 = (a[5] * 5);
                exitLoop = true;
            };

            if ((choice == 'r') && (s6 == -1))
            {
                s6 = (a[6] * 6);
                exitLoop = true;
            };

            if ((choice == 's') && (TK == -1))
            {
                TK = Dice.ThreeOfAKind(a);
                exitLoop = true;
            };

            if ((choice == 't') && (FK == -1))
            {
                FK = Dice.FourOfAKind(a);
                exitLoop = true;
            };

            if ((choice == 'u') && (FH == -1))
            {
                FH = Dice.FullHouse(a);
                exitLoop = true;
            };

            if ((choice == 'v') && (SS == -1))
            {
                SS = Dice.SmallStraight(a);
                exitLoop = true;
            };

            if ((choice == 'w') && (LS == -1))
            {
                LS = Dice.LargeStraight(a);
                exitLoop = true;
            };

            if ((choice == 'x') && (CH == -1))
            {
                CH = Dice.Chance(a);
                exitLoop = true;
            };

            if ((choice == 'y') && (YA == -1))
            {
                YA = Dice.Yahtzee(a);
                exitLoop = true;
            };
        }
    }

    // Scores written to the screen

    public void Card()
    {
        Clear();
        string nextLine = "";
        string[] outPut = new string[16];

        outPut[0] = "";
        outPut[1] = "     SCORE CARD";
        outPut[2] = "";

        outPut[3] = "     Ones                  ";
        if (s1 == -1)
        {
            outPut[3] += "m";
        }
        else
        {
            outPut[3] += $"{s1}";
        }

        outPut[4] = "     Twos                  ";
        if (s2 == -1)
        {
            outPut[4] += "n";
        }
        else
        {
            outPut[4] += $"{s2}";
        }

        outPut[5] = "     Threes                ";
        if (s3 == -1)
        {
            outPut[5] += "o";
        }
        else
        {
            outPut[5] += $"{s3}";
        }

        outPut[6] = "     Fours                 ";
        if (s4 == -1)
        {
            outPut[6] += "p";
        }
        else
        {
            outPut[6] += $"{s4}";
        }

        outPut[7] = "     Fives                 ";
        if (s5 == -1)
        {
            outPut[7] += "q";
        }
        else
        {
            outPut[7] += $"{s5}";
        }

        outPut[8] = "     Sixes                 ";
        if (s6 == -1)
        {
            outPut[8] += "r";
        }
        else
        {
            outPut[8] += $"{s6}";
        }

        outPut[9] = "     Three of a Kind       ";
        if (TK == -1)
        {
            outPut[9] += "s";
        }
        else
        {
            outPut[9] += $"{TK}";
        }

        outPut[10] = "     Four of a Kind        ";
        if (FK == -1)
        {
            outPut[10] += "t";
        }
        else
        {
            outPut[10] += $"{FK}";
        }

        outPut[11] = "     Full House            ";
        if (FH == -1)
        {
            outPut[11] += "u";
        }
        else
        {
            outPut[11] += $"{FH}";
        }

        outPut[12] = "     Small Straight        ";
        if (SS == -1)
        {
            outPut[12] += "v";
        }
        else
        {
            outPut[12] += $"{SS}";
        }

        outPut[13] = "     Large Straight        ";
        if (LS == -1)
        {
            outPut[13] += "w";
        }
        else
        {
            outPut[13] += $"{LS}";
        }

        outPut[14] = "     Chance                ";
        if (CH == -1)
        {
            outPut[14] += "x";
        }
        else
        {
            outPut[14] += $"{CH}";
        }

        outPut[15] = "     Yahtzee               ";
        if (YA == -1)
        {
            outPut[15] += "y";
        }
        else
        {
            outPut[15] += $"{YA}";
        }

        for (int line = 0; line < 16; line++)
        {
            nextLine = outPut[line];
            WriteLine(nextLine);
        }
    }

        // Scores written to both the file "final.txt", and the screen

    public void Final()
    {
        Clear();
        string nextLine = "";
        string[] outPut = {
            "",
            "     FINAL SCORE CARD",
            "",
            $"     Ones                  {s1}",
            $"     Twos                  {s2}",
            $"     Threes                {s3}",
            $"     Fours                 {s4}",
            $"     Fives                 {s5}",
            $"     Sixes                 {s6}",
            "",
            $"     Upper Total           {UpperTotal()}",
            $"     Upper Bonus           {UpperBonus()}",
            "",
            $"     Three of a Kind       {TK}",
            $"     Four of a Kind        {FK}",
            $"     Full House            {FH}",
            $"     Small Straight        {SS}",
            $"     Large Straight        {LS}",
            $"     Chance                {CH}",
            $"     Yahtzee               {YA}",
            "",
            $"     GRAND TOTAL           {GrandTotal()}",
            ""
        };

        string path = @".\final.txt";
        using (StreamWriter sw = File.AppendText(path))

        for (int line = 0; line < 23; line++)
        {
            nextLine = outPut[line];
            sw.WriteLine(nextLine);
               WriteLine(nextLine);
        }
        Write("     Press any key to close ");
        ReadKey();
    }

    /* Total of the upper section */

    public int UpperTotal()
    {
        return (s1 + s2 + s3 + s4 + s5 + s6);
    }

    /* If the upper section total is greater than 62, then a bonus of 35 is awarded */

    public int UpperBonus()
    {
        int value = 0;
        if (UpperTotal() > 62)
        {
            value = 35;
        }
        return value;
    }

    /* Total of all scores */

    public int GrandTotal()
    {
        return (UpperTotal() + UpperBonus() + TK + FK + FH + SS + LS + CH + YA);
    }
}
