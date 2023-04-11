using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory
{
    public event EventHandler OnItemListChanged;
    private List<Item> itemList;

    public GameObject panelItemUsed;
    public SpriteRenderer ItemSprite;

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


public void UseItem(Item item)
{
    panelItemUsed.SetActive(true);
    ItemSprite.sprite = item.GetSprite();//Faire afficher le flyer en grand
    //Supprimer l'item de l'inventaire
    //Ajouter une condition d'utilisation selon les éngimes
}

public List<Item> GetItemList() {
    return itemList;
}
}

