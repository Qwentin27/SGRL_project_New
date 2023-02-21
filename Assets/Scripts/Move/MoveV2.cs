using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveV2 : MonoBehaviour{
    [SerializeField] float speed;
    Rigidbody rb;
    Transform tr;
    [SerializeField] GameObject cam;


    void Start(){
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>(); // vitesse constante qu'importe orientation caméra
        //tr = cam.GetComponent<Transform>(); // ralentit, vitesse selon cosinus(caméra ^ sol)
    }

    void FixedUpdate(){
        float vert = Input.GetAxis("Vertical"), hori = Input.GetAxis("Horizontal");

        /*Vector3 movement = new Vector3(
            hori * Time.fixedDeltaTime * speed * tr.right.x,
            0 ,
            vert * Time.fixedDeltaTime * speed * tr.forward.z );
            
        C'EST NON ! parce que tr.right.x représente la projection sur l'axe x.
        Donc, si on est perpendiculaire à l'axe x, le cos vaut 0 et donc on n'avancera pas    
        */

        Vector3 movement = hori * Time.fixedDeltaTime * speed * tr.right + vert * Time.fixedDeltaTime * speed * tr.forward;
        movement.y = 0;//   évite les sauts en regardant en haut
        // NPO : à cause de la gravité, déplacement selon X ou Z involontaire
        // --> nécessite une pente à forte friction statique, i.e Physical Material
        rb.MovePosition(transform.position + movement );
    }
}
