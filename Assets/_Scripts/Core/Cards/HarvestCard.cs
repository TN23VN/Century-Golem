using UnityEngine;

public class HarvestCard : ICardAction
{
    public string CardName => "Thu hoạch đá";

    private GemType[] gemsToAdd;

    public HarvestCard(params GemType[] gems)
    {
        gemsToAdd = gems;
    }

    public void Execute(PlayerState player)
    {
        foreach (var gem in gemsToAdd)
        {
            player.Inventory.AddGem(gem);
        }
    }
}
