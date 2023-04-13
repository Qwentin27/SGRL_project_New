using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType {
        Flyer,
        CartePostale,
        Tasse,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch(itemType)
        {
            default:
            case ItemType.Flyer: return ItemAssets.Instance.FlyerSprite;
            case ItemType.CartePostale: return ItemAssets.Instance.CartePostaleSprite;
        }
    }

    public string GetText()
    {
        switch(itemType)
        {
            default:
            case ItemType.Flyer: return ItemAssets.Instance.sentences[0];
            case ItemType.CartePostale: return ItemAssets.Instance.sentences[1];
        }
    }
}
