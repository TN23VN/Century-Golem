using System;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    public Image icon;
    public Text cardName;
    public Button playButton;

    private ICardAction cardAction;
    private Action<ICardAction> onPlay;

    public void Setup(string name, Sprite sprite, ICardAction action, Action<ICardAction> callback)
    {
        cardName.text = name;
        icon.sprite = sprite;
        cardAction = action;
        onPlay = callback;
        playButton.onClick.AddListener(() => onPlay?.Invoke(cardAction));
    }
}
