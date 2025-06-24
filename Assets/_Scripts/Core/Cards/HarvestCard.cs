using UnityEngine;

public class HarvestCard : ICardAction
{
    private readonly int[] gems;

    public HarvestCard(int[] gems)
    {
        this.gems = gems;
    }

    public void Execute(PlayerInventory inventory)
    {
        inventory.AddGems(gems);
    }
}
