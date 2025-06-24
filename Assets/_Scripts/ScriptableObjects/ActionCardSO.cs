using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewCard", menuName = "Century/Card Action", order = 1)]
public class ActionCardSO : ScriptableObject
{
    public string cardName;
    public Sprite icon;

    public CardActionType actionType;

    // Dùng cho Harvest
    public List<GemType> gemsToAdd;

    // Dùng cho Upgrade
    public GemType upgradeFrom;
    public GemType upgradeTo;

    // Dùng cho Trade
    public GemType tradeFrom;
    public GemType tradeTo;
}

public enum CardActionType
{
    Harvest,
    Upgrade,
    Trade
}
