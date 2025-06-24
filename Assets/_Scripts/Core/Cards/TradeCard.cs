using UnityEngine;

public class TradeCard : ICardAction
{
    public string CardName => "Đổi đá";

    private GemType give;
    private GemType receive;

    public TradeCard(GemType give, GemType receive)
    {
        this.give = give;
        this.receive = receive;
    }

    public void Execute(PlayerState player)
    {
        if (player.Inventory.RemoveGem(give))
            player.Inventory.AddGem(receive);
    }
}
