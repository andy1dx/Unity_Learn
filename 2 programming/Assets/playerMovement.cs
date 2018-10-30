using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    
    // This is reference to the rigid body component called "rb"
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        //rb.AddForce(0, 0, 200);
    }

    // we marked 'Fixed Update' because we using it to render with physics
    void FixedUpdate () {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); // add a force of 2000 z-axis per second
    }
}
