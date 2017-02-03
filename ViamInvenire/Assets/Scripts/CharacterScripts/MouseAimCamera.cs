using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAimCamera : MonoBehaviour {

    // Use this for initialization
    // speed is the rate at which the object will rotate
    public float speed = 5.0f;

    private Vector3 look;

    void FixedUpdate()
    {
        look.x = 0; //Input.GetAxis("Mouse X");
        look.y = Input.GetAxis("Mouse X");

        look.z = 0;

        this.transform.Rotate(look, speed);
        
    }
}
