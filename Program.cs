Terminal.Fixed("Yahtzee", false, 60, 30);
int[] dice = new int[7];
Score card = new Score();

for (int i = 0; i < 13; i++)
{
    Dice.Default(dice);
    Dice.Count(dice);
    card.PlayerReRolls(dice);
    if (Dice.SecondRound(dice))
    {
        Dice.Count(dice);
        card.PlayerReRolls(dice);
    };
    Dice.Count(dice);
    card.Selection(dice);
};

card.Final();
