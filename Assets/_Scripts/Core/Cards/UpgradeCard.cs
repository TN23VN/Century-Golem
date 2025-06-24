using UnityEngine;

public class UpgradeCard : ICardAction
{
    public string CardName => "Nâng cấp đá";

    private GemType from, to;

    public UpgradeCard(GemType from, GemType to)
    {
        this.from = from;
        this.to = to;
    }

    public void Execute(PlayerState player)
    {
        if (player.Inventory.RemoveGem(from))
            player.Inventory.AddGem(to);
    }
}
