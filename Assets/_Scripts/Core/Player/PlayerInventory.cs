using UnityEngine;

public class PlayerInventory
{
    private int[] gems = new int[4]; // 0=vang, 1=do, 2=xanhla, 3=xanhduong

    public void AddGems(int[] gain)
    {
        for (int i = 0; i < 4; i++)
            gems[i] += gain[i];
    }

    public int[] GetGems() => gems;
}
