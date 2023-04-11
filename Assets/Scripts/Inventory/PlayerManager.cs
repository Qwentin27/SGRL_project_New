using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private Inventory inventory;
    // Start is called before the first frame update
    [SerializeField] private UI_Inventory uiInventory;
    
    void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

        ItemWorld.SpawnItemWorld(new Vector3(20, 5), new Item {itemType = Item.ItemType.Flyer, amount = 1});
        ItemWorld.SpawnItemWorld(new Vector3(-20, 5), new Item {itemType = Item.ItemType.CartePostale, amount = 1});

    }


    private void OnTriggerEnter (Collider collider)
    {
        ItemWorld itemWorld = collider.GetComponent<ItemWorld>();
        if(itemWorld != null)
        {
            //Touching Item
            inventory.AddItem(itemWorld.GetItem());
            itemWorld.DestroySelf();
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
