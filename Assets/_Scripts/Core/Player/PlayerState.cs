using UnityEngine;

public class PlayerState
{
    public string Name { get; private set; }
    public PlayerInventory Inventory { get; private set; }

    public PlayerState(string name)
    {
        Name = name;
        Inventory = new PlayerInventory();
    }
}
