using UnityEngine;

public interface ICardAction
{
    string CardName { get; }
    Sprite Icon { get; }
    void Execute(PlayerState player);
}
