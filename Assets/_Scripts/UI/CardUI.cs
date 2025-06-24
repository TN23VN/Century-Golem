using System;
using UnityEngine;
using UnityEngine.UI;

public class CardUI : MonoBehaviour
{
    public Image icon;
    public Text cardName;
    public Button playButton;

    private Action onClick;

    public void Setup(string name, Sprite sprite, Action onClick)
    {
        cardName.text = name;
        icon.sprite = sprite;
        this.onClick = onClick;

        playButton.onClick.RemoveAllListeners();
        playButton.onClick.AddListener(() => onClick?.Invoke());
    }
}
