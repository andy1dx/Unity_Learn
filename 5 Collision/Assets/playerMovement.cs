using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour {
    
    // This is reference to the rigid body component called "rb"
    public Rigidbody rb;

    // 変数の設定
    public float forwardForce = 2000f; //前進動きの数
    public float sideForce = 500f;　//横に動きの数

    // Use this for initialization
    void Start () {
        //rb.AddForce(0, 0, 200);
    }

    // we marked 'Fixed Update' because we using it to render with physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // add a force of 2000 z-axis per second
        //右側に動き
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0);
        }
        //左側に動き
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0);
        }

    }

}
