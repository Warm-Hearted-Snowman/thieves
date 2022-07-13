using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody rb;
    int ballmove=500;
    //int ballback = 25;
    int ballwall = 2000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      // if (rb.velocity.magnitude >ballmove)
      //    {
      //        rb.velocity = rb.velocity.normalized * ballmove;
      //    }
    }
   
   
    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag=="Player")
        {
              rb.AddForce(0,0,-ballmove*Time.deltaTime);
        }
          if(other.transform.tag=="billdenemy")
        {
           Destroy(other.gameObject);
            rb.AddForce(0,0,ballmove*Time.deltaTime);

        }
          if(other.transform.tag=="Enemy")
        {
           Destroy(other.gameObject);
            rb.AddForce(0,0,ballmove*Time.deltaTime);

        }
          if(other.transform.tag=="wall")
        {
          rb.AddForce(ballwall*Time.deltaTime,0,0);

        }
           if(other.transform.tag=="lwall")
        {
          rb.AddForce(-ballwall*Time.deltaTime,0,0);

        }
           if(other.transform.tag=="deadline")
        {
          Destroy(rb.gameObject);

        }


        

    }
}
 