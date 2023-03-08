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
}
