using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemUse : MonoBehaviour
{

    public GameObject panelItemUsed;
    public SpriteRenderer ItemSprite;
    public Image image;
    private Item item;

    private void Start()
    {
        panelItemUsed.SetActive(false);
    }

   public void DisplayItem()
{
    panelItemUsed.SetActive(true);
    //ItemSprite.sprite = item.GetSprite();
    Image itemImage = gameObject.transform.Find("image").GetComponent<Image>();
    image.sprite = itemImage.sprite;
    Debug.Log("Item utilisé");//Faire afficher le flyer en grand
    //Supprimer l'item de l'inventaire
    //Ajouter une condition d'utilisation selon les éngimes
}

}