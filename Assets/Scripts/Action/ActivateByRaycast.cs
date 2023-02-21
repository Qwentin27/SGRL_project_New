using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateByRaycast : MonoBehaviour{
    [SerializeField] float maxDistance;
    private float SPHERE_DETECTION_RADIUS = 0.1f;

    void Update(){
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward * maxDistance);
        
        if(Input.GetKeyDown(KeyCode.E)){
            Debug.Log("[Debug] On button pushed");
            Debug.DrawRay(transform.position, transform.forward * maxDistance, Color.red);
            if(Physics.SphereCast(ray, SPHERE_DETECTION_RADIUS, out hit, maxDistance)){
                Debug.Log("[Debug] On sphere cast hit");
                Activate(hit);
            }
        }else{
            Debug.DrawRay(transform.position, transform.forward * maxDistance);
        }
    }

    private void Activate(RaycastHit hit){
        GameObject gameobjectHitted = hit.collider.gameObject;
        Debug.Log("[Debug] In raycast Activate");
        foreach(Component component in gameobjectHitted.GetComponents(typeof(Component))){
            print("Before actionnable test");
            if(component is IActionable){
                print("After actionnable test");
                ((IActionable)component).Action();
            }
            else{
                Debug.Log("Does not find IActionnable");
            }
        }
    }
}

