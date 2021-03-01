using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenu : MonoBehaviour
{
public float velocidad = 0.75f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,1,0)*velocidad);
    }
}
