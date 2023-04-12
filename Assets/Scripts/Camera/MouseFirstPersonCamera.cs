using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFirstPersonCamera : MonoBehaviour{
    public float mouseSensitivity = 1f;

    public Transform playerBody;

    private float xRotation = 0f;

    public MoveV2 playerMove;

    
    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
    }

    /*void FixedUpdate(){
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.fixedDeltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.fixedDeltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90); // clamp l'angle

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }*/

    void Update(){
    if(playerMove.gameEnCours == true)
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90, 90); // clamp l'angle

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        playerBody.Rotate(Vector3.up * mouseX);
    }
    }

}
