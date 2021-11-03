using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public float turnSpeed = 90f; 
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Hero")
        {
            return; 
        }

        GameManager.inst.IncrementScore(); 
        Destroy(gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(0,0, turnSpeed*Time.deltaTime);
    }
}
