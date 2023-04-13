using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour
{
    private Inventory inventory;
    // Start is called before the first frame update
    [SerializeField] private UI_Inventory uiInventory;
    public GameObject panel_Interaction;
    private ItemWorld itemWorld2;
    
    void Start()
    {
        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

        ItemWorld.SpawnItemWorld(new Vector3(20, 5), new Item {itemType = Item.ItemType.Flyer, amount = 1});
        ItemWorld.SpawnItemWorld(new Vector3(-20, 5), new Item {itemType = Item.ItemType.CartePostale, amount = 1});
        panel_Interaction.SetActive(false);        

    }


    void OnTriggerEnter (Collider collider)
    {
        panel_Interaction.SetActive(true);
        ItemWorld itemWorld = collider.GetComponent<ItemWorld>();
        itemWorld2 = itemWorld;
        // if(itemWorld != null)
        // {
        //     inventory.AddItem(itemWorld.GetItem());
        //     itemWorld.DestroySelf();
        // }
    }

    void OnTriggerExit(Collider collider)
    {
        panel_Interaction.SetActive(false);
        itemWorld2 = null;
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Debug.Log("espace");
            if(itemWorld2 != null)
            {
            inventory.AddItem(itemWorld2.GetItem());
            itemWorld2.DestroySelf();
            panel_Interaction.SetActive(false);
            }
        }
    }
}

