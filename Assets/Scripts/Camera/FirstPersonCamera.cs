using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour{
    [SerializeField] float degree_clamp;

    private float degree_clamp_neg, degree_clamp_pos;
    public float angular_speed;

    void Start(){
        degree_clamp_neg = 270 + degree_clamp;
        degree_clamp_pos = 90 - degree_clamp;
    }
/*
   void FixedUpdate(){
        if(Input.GetAxis("VerticalCamera") != 0){
            Vector3 vertical_rotation = new Vector3(Input.GetAxis("VerticalCamera") * Time.fixedDeltaTime * angular_speed * -1,0,0);
            transform.Rotate( vertical_rotation, Space.Self );
        }

        if(Input.GetAxis("HorizontalCamera") != 0){
            Vector3 horizontal_rotation = new Vector3(0, Input.GetAxis("HorizontalCamera") * Time.fixedDeltaTime * angular_speed,0);
            transform.Rotate( horizontal_rotation, Space.World );
        }

        if(transform.localEulerAngles.x  < degree_clamp_neg && transform.localEulerAngles.x > 90){
            transform.localEulerAngles = new Vector3(degree_clamp_neg, transform.localEulerAngles.y, 0);//Quaternion.Euler(degree_clamp_neg, transform.rotation.y, 0);
        }
        else if(transform.localEulerAngles.x > degree_clamp_pos && transform.localEulerAngles.x < 180){
            transform.localEulerAngles = new Vector3(degree_clamp_pos, transform.localEulerAngles.y, 0);//Quaternion.Euler(degree_clamp_pos, transform.rotation.y, 0);
        }
    }*/

   void Update(){
        if(Input.GetAxis("VerticalCamera") != 0){
            Vector3 vertical_rotation = new Vector3(Input.GetAxis("VerticalCamera") * Time.deltaTime * angular_speed * -1,0,0);
            transform.Rotate( vertical_rotation, Space.Self );
        }

        if(Input.GetAxis("HorizontalCamera") != 0){
            Vector3 horizontal_rotation = new Vector3(0, Input.GetAxis("HorizontalCamera") * Time.deltaTime * angular_speed,0);
            transform.Rotate( horizontal_rotation, Space.World );
        }

        if(transform.localEulerAngles.x  < degree_clamp_neg && transform.localEulerAngles.x > 90){
            transform.localEulerAngles = new Vector3(degree_clamp_neg, transform.localEulerAngles.y, 0);//Quaternion.Euler(degree_clamp_neg, transform.rotation.y, 0);
        }
        else if(transform.localEulerAngles.x > degree_clamp_pos && transform.localEulerAngles.x < 180){
            transform.localEulerAngles = new Vector3(degree_clamp_pos, transform.localEulerAngles.y, 0);//Quaternion.Euler(degree_clamp_pos, transform.rotation.y, 0);
        }
    }

}
