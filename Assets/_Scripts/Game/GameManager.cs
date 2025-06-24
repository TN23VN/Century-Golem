using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.XR;

public class GameManager : MonoBehaviour
{
    public PlayerUI ui;
    public List<InventorySlotUI> inventorySlots;

    private PlayerState currentPlayer;
    private List<ICardAction> hand;

    public void ShowInventory(List<GemType> gems)
    {
        for (int i = 0; i < inventorySlots.Count; i++)
        {
            var gem = (i < gems.Count) ? gems[i] : GemType.None;
            inventorySlots[i].SetGem(gem);
        }
    }

    void Start()
    {
        currentPlayer = new PlayerState("Người chơi 1");
        hand = FirstCard.GetSampleCards();

        UpdateUI();
    }

    void UpdateUI()
    {
        ui.SetTurnInfo(currentPlayer.Name);
        ui.ShowInventory(currentPlayer.Inventory.GetCurrentGems());
        ui.ShowHand(ConvertToCardData(hand), PlayCard);
    }

    void PlayCard(int index)
    {
        if (index >= 0 && index < hand.Count)
        {
            var card = hand[index];
            card.Execute(currentPlayer);

            hand.RemoveAt(index); // chơi xong bỏ khỏi tay
            UpdateUI();
        }
    }

    List<CardData> ConvertToCardData(List<ICardAction> cards)
    {
        return cards.Select(c => new CardData { name = c.CardName }).ToList();
    }
}
