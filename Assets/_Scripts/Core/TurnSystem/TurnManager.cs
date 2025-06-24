using UnityEngine;

public class TurnManager
{
    private int soPlayerhientai;
    private int tongsoPlayer;

    public TurnManager(int playerCount)
    {
        tongsoPlayer = playerCount;
        soPlayerhientai = 0;
    }

    public int GetCurrentPlayer() => soPlayerhientai;

    public void NextTurn()
    {
        soPlayerhientai = (soPlayerhientai + 1) % tongsoPlayer;
    }
}
