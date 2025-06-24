using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "NewCard", menuName = "Century/Card Action", order = 1)]
public class ActionCardSO : ScriptableObject
{
    public string cardName;
    public Sprite icon;

    public CardActionType actionType;

    // D�ng cho Harvest
    public List<GemType> gemsToAdd;

    // D�ng cho Upgrade
    public GemType upgradeFrom;
    public GemType upgradeTo;

    // D�ng cho Trade
    public GemType tradeFrom;
    public GemType tradeTo;
}

public enum CardActionType
{
    Harvest,
    Upgrade,
    Trade
}
