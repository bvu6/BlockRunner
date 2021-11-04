using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class PlayerMovement : MonoBehaviour
{
    public float speed = 20;

    public Rigidbody rb;

    private float horizInput;

    public float horizMult = 2;

    private bool alive = true;

    public float speedIncrease = 0.1f;

    [SerializeField] private float jumpForce = 400f;
    [SerializeField] LayerMask GroundMask; 
    
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (transform.position.y < -5) //if hero goes off plane
        {
            Die();
        }

    }

    void Jump()
    {
        float height = GetComponent<Collider>().bounds.size.y;//get ground
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2)+0.1f, GroundMask); 
        
        rb.AddForce(Vector3.up * jumpForce);
    }

    public void Die()
    {
        alive = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Finish"))
        {
            speed = 0; 
            Debug.Log("You win!");
        }
    }
    

    
}
