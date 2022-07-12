using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody rb;
    int move = 8000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("w"))
        {
          //transform.Translate(new Vector3(0, 0, 6) * Time.deltaTime);
           rb.AddForce(0,0,-move*Time.deltaTime);
           
         
        }
        if(Input.GetKey("s"))
        {
            //transform.Translate(new Vector3(0, 0, -6) * Time.deltaTime);
            rb.AddForce(0,0,move*Time.deltaTime);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(move*Time.deltaTime,0,0);
        }
        if(Input.GetKey("d"))
        {
           rb.AddForce(-move*Time.deltaTime,0,0);
        }
        
        
    }

}
