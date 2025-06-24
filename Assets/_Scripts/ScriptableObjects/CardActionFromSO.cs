using UnityEngine;

public class CardActionFromSO : ICardAction
{
    private ActionCardSO data;

    public string CardName => data.cardName;
    public Sprite Icon => data.icon;

    public CardActionFromSO(ActionCardSO so)
    {
        data = so;
    }

    public void Execute(PlayerState player)
    {
        switch (data.actionType)
        {
            case CardActionType.Harvest:
                foreach (var gem in data.gemsToAdd)
                    player.Inventory.AddGem(gem);
                break;

            case CardActionType.Upgrade:
                if (player.Inventory.RemoveGem(data.upgradeFrom))
                    player.Inventory.AddGem(data.upgradeTo);
                break;

            case CardActionType.Trade:
                if (player.Inventory.RemoveGem(data.tradeFrom))
                    player.Inventory.AddGem(data.tradeTo);
                break;
        }
    }
}
