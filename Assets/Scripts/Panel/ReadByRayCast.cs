using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadByRayCast : MonoBehaviour{
    [SerializeField] float maxDistance;
    private GameObject previous;
    private bool hasHit;
    private Component compo = null;

    void Update(){
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward * maxDistance);

        hasHit = Physics.Raycast(ray, out hit, maxDistance);
        if(hasHit){
            this.Display(hit);
        }
        else if(compo != null){
            ((Displayable)compo).Hide();
            compo = null;
            previous = null;
        }
    }

    void Display(RaycastHit hit){
        GameObject gameobjectHitted = hit.collider.gameObject;

        if(gameobjectHitted != previous){
            if(previous != null)
                ((Displayable)compo).Hide();
            foreach(Component component in gameobjectHitted.GetComponents(typeof(Component))){
                if(component is Displayable){
                    compo = component;
                    ((Displayable)component).Display();
                    previous = gameobjectHitted;
                }
            }
        }
        else{
            ((Displayable)compo).Display();
        }
    }
}
