using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20;

    public Rigidbody rb;

    private float horizInput;

    public float horizMult = 2;

    private bool alive = true; 
    // Start is called before the first frame update
    private void FixedUpdate()
    {
        if (!alive) return; 
        Vector3 forward = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horiz = transform.right * horizInput * speed * Time.fixedDeltaTime * horizMult; 
        rb.MovePosition(rb.position + forward + horiz);
    }

    // Update is called once per frame
    private void Update()
    {
        horizInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5) //if hero goes off plane
        {
            Die();
        }

    }

    public void Die()
    {
        alive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
    }
}
