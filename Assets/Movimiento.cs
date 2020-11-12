using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {

    public Camera FPSCamara;
    public float horizontalSpeed;
    public float verticalSpeed;

    float H;
    float V;

    void Start () {

    }
    

    void Update()
    {

        H = horizontalSpeed * Input.GetAxis("Mouse X");
        V = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0, H, 0);
        FPSCamara.transform.Rotate(-V,0,0);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0,0,0.1f);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f,0,0);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0,0,-0.1f);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.1f,0,0);
        }
	}
}
