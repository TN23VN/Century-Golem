using System.Collections.Generic;
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
    public const int MaxSlot = 12;
    private List<GemType> slots = new List<GemType>(MaxSlot);

    private int[] gems = new int[4]; // 0=vang, 1=do, 2=xanhla, 3=xanhduong

    public PlayerInventory()
    {
        for (int i = 0; i < MaxSlot; i++)
            slots.Add(GemType.None);
    }


    public bool AddGem(GemType gem)
    {
        for (int i = 0; i < MaxSlot; i++)
        {
            if (slots[i] == GemType.None)
            {
                slots[i] = gem;
                return true;
            }
        }
        return false; // inventory đầy
    }

    public bool RemoveGem(GemType gem)
    {
        for (int i = 0; i < MaxSlot; i++)
        {
            if (slots[i] == gem)
            {
                slots[i] = GemType.None;
                return true;
            }
        }
        return false; // không tìm thấy đá để xóa
    }

    public List<GemType> GetCurrentGems()
    {
        return new List<GemType>(slots);
    }

    public int CountGem(GemType gem)
    {
        int count = 0;
        foreach (var g in slots)
            if (g == gem) count++;
        return count;
    }

    public void ClearAll()
    {
        for (int i = 0; i < MaxSlot; i++)
            slots[i] = GemType.None;
    }

    public int[] GetGems() => gems;
}
