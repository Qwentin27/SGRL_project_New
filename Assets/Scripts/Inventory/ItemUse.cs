using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUse : MonoBehaviour
{

    public GameObject panelItemUsed;
    public SpriteRenderer ItemSprite;
    private Item item;

    private void Start()
    {
        panelItemUsed.SetActive(false);
    }

   public void UseItem()
{
    panelItemUsed.SetActive(true);
    ItemSprite.sprite = item.GetSprite();
    Debug.Log("Item utilisé");//Faire afficher le flyer en grand
    //Supprimer l'item de l'inventaire
    //Ajouter une condition d'utilisation selon les éngimes
}

}
