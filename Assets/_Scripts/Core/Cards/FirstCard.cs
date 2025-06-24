using System.Collections.Generic;
using UnityEngine;

public class FirstCard
{
    public static List<ICardAction> LoadCardsFromSO()
    {
        var cardSOs = Resources.LoadAll<ActionCardSO>("Cards");
        var result = new List<ICardAction>();

        foreach (var so in cardSOs)
        {
            result.Add(new CardActionFromSO(so));
        }

        return result;
    }
}
