using System.Collections.Generic;
using UnityEngine;

public class FirstCard
{
    public static List<ICardAction> GetSampleCards()
    {
        return new List<ICardAction>
        {
            new HarvestCard(GemType.Yellow, GemType.Yellow),
            new UpgradeCard(GemType.Yellow, GemType.Red),
            new TradeCard(GemType.Red, GemType.Green)
        };
    }
}
