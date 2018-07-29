using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour {

    private Rigidbody rb;

    public float upForce;
    public float speed;
    public float jump=2.5f;
    public float gravity=2f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    
    void FixedUpdate()

    {
        //Debug.Log(rb.velocity.y);//velocity in Y
        //Debug.Log(Physics.gravity.y); //Gravity/ms in y

        if (Input.GetMouseButtonDown(0))
        {

            rb.velocity = new Vector3(0, 0, speed);  
        }
        else if(rb.velocity.y < 0 && Input.GetMouseButtonDown(1))
            {
                rb.velocity += Vector3.up * upForce * -Physics.gravity.y * (jump-1) * Time.deltaTime;
                
            }
        else if (rb.velocity.y > 2 && !Input.GetMouseButtonDown(1))
        {
           
            rb.velocity += Vector3.up * Physics.gravity.y * (gravity - 1) * Time.deltaTime;
           
        }


    }
}
