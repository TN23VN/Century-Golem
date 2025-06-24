using UnityEngine;
using UnityEngine.UI;

public class InventorySlotUI : MonoBehaviour
{
    public Image icon;
    public Sprite emptySprite;
    public Sprite yellowGem;
    public Sprite redGem;
    public Sprite greenGem;
    public Sprite blueGem;
    public void SetGem(GemType gem)
    {
        switch (gem)
        {
            case GemType.Yellow:
                icon.sprite = yellowGem;
                break;
            case GemType.Red:
                icon.sprite = redGem;
                break;
            case GemType.Green:
                icon.sprite = greenGem;
                break;
            case GemType.Blue:
                icon.sprite = blueGem;
                break;
            default:
                icon.sprite = emptySprite;
                break;
        }
    }
}
