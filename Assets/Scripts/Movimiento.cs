using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour {
    public float velocidad;
    //public Rigidbody cuerporigido;
    public CharacterController control;

    private Vector3 moverDireccion;
	// Use this for initialization
	void Start () {
        control = GetComponent<CharacterController>();      //  cuerporigido = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        //  cuerporigido.velocity = new Vector3(Input.GetAxis("Horizontal") * velocidad, cuerporigido.velocity.y, Input.GetAxis("Vertical") * velocidad );
        moverDireccion = new Vector3(Input.GetAxis("Horizontal") * velocidad, 0f, Input.GetAxis("Vertical") * velocidad);
        moverDireccion.y = moverDireccion.y + (Physics.gravity.y*Time.deltaTime);
        control.Move(moverDireccion*Time.deltaTime);
    }
}
