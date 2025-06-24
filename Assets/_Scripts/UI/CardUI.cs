using System;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    public Text cardName;
    public Button playButton;

    private ICardAction cardAction;
    private Action<ICardAction> onPlay;

    public void Setup(string name, ICardAction action, Action<ICardAction> callback)
    {
        cardName.text = name;
        cardAction = action;
        onPlay = callback;
        playButton.onClick.AddListener(() => onPlay?.Invoke(cardAction));
    }
}
