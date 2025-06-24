using UnityEngine;

public interface ICardAction
{
    string CardName { get; }
    void Execute(PlayerState player);
}
