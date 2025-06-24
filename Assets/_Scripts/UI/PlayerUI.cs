using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerUI : MonoBehaviour 
{
    public Transform handArea;
    public GameObject cardUIPrefab;

    public TMP_Text turnText;
    public TMP_Text[] gemTexts;

    public GameObject restButton;
    public GameObject nextTurnButton;

    public List<InventorySlotUI> inventorySlots;

    public void ShowInventory(List<GemType> gems)
    {
        for (int i = 0; i < inventorySlots.Count; i++)
        {
            var gem = (i < gems.Count) ? gems[i] : GemType.None;
            inventorySlots[i].SetGem(gem);
        }
    }

    public void ShowHand(List<CardData> hand, System.Action<int> onPlayCard)
    {
        foreach (Transform child in handArea)
            Destroy(child.gameObject);

        for (int i = 0; i < hand.Count; i++)
        {
            int index = i;
            var card = hand[i];

            var ui = Instantiate(cardUIPrefab, handArea).GetComponent<CardUI>();
            ui.Setup(card.name, card.sprite, () => onPlayCard(index));
        }
    }

    public void ShowGems(int[] gems)
    {
        for (int i = 0; i < gemTexts.Length; i++)
        {
            gemTexts[i].text = gems[i].ToString();
        }
    }

    public void SetTurnInfo(string text)
    {
        turnText.text = text;
    }
    /*/
    public void SetRestButton(System.Action onRest)
    {
        restButton.GetComponent<Button>().onClick.RemoveAllListeners();
        restButton.GetComponent<Button>().onClick.AddListener(() => onRest?.Invoke());
    }

    public void SetNextTurnButton(System.Action onNext)
    {
        nextTurnButton.GetComponent<Button>().onClick.RemoveAllListeners();
        nextTurnButton.GetComponent<Button>().onClick.AddListener(() => onNext?.Invoke());
    }/*/
}
