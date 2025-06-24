using UnityEngine;
public enum GemType
{
    None = -1,
    Yellow = 0,
    Red = 1,
    Green = 2,
    Blue = 3
}
public class PlayerInventory
{
    public const int MaxSlot = 10;
    private int[] gems = new int[4]; // 0=vang, 1=do, 2=xanhla, 3=xanhduong

    public void AddGems(int[] gain)
    {
        for (int i = 0; i < 4; i++)
            gems[i] += gain[i];
    }

    public int[] GetGems() => gems;
}
