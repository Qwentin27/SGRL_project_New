using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory
{
    public event EventHandler OnItemListChanged;
    private List<Item> itemList;

    public Inventory()
    {
        itemList = new List<Item>();

        AddItem(new Item { itemType = Item.ItemType.Flyer, amount = 1});
        AddItem(new Item { itemType = Item.ItemType.CartePostale, amount = 1});

    }

public void AddItem (Item item)
{
    itemList.Add(item);
    OnItemListChanged?.Invoke(this, EventArgs.Empty);
}

public void RemoveItem(Item item)
{
    itemList.Remove(item);
}




public List<Item> GetItemList() {
    return itemList;
}
}

