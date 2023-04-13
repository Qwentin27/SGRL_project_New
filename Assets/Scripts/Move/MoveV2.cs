using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveV2 : MonoBehaviour{
    [SerializeField] float speed;
    Rigidbody rb;
    Transform tr;
    [SerializeField] GameObject cam;

    public GameObject PanelUI;
    public GameObject Panel_ItemUsed;
    public bool gameEnCours = true;


    void Start(){
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>(); // vitesse constante qu'importe orientation caméra
        //tr = cam.GetComponent<Transform>(); // ralentit, vitesse selon cosinus(caméra ^ sol)
        PanelUI.SetActive(false);
        Panel_ItemUsed.SetActive(false);
    }

    void FixedUpdate(){
        if(gameEnCours==true)
        {
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

        if(Input.GetKeyDown(KeyCode.I) && gameEnCours == true)
        {
            Cursor.lockState = CursorLockMode.None;
            PanelUI.SetActive(true);
            gameEnCours = false;
            Debug.Log("Inventaire ouvert");
        }

        if(Input.GetKeyDown(KeyCode.O) && gameEnCours == false)
        {
            Cursor.lockState = CursorLockMode.Locked;
            PanelUI.SetActive(false);
            Panel_ItemUsed.SetActive(false);
            gameEnCours = true;
            Debug.Log("Inventaire fermé");
        }
        
    }
}
