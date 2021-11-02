using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10;

    public Rigidbody rb;

    private float horizInput;

    public float horizMult = 2; 
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        Vector3 forward = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horiz = transform.right * horizInput * speed * Time.fixedDeltaTime * horizMult; 
        rb.MovePosition(rb.position + forward + horiz);
    }

    // Update is called once per frame
    private void Update()
    {
        horizInput = Input.GetAxis("Horizontal"); 

    }
}
