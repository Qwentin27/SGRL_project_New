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
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
