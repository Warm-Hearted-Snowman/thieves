using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    void FixedUpdate()
    {
      if(Input.GetKey("w"))
        {
             transform.Translate(new Vector3(0, 0, 10) * Time.deltaTime);
        }
        if(Input.GetKey("a"))
        {
             transform.Translate(new Vector3(-10, 0, 0) * Time.deltaTime);
        }
        if(Input.GetKey("s"))
        {
             transform.Translate(new Vector3(0, 0, -10) * Time.deltaTime);
        }
        if(Input.GetKey("d"))
        {
             transform.Translate(new Vector3(10, 0, 0) * Time.deltaTime);
        }
         if(Input.GetKey("i"))
        {
             transform.Translate(new Vector3(0, 10, 0) * Time.deltaTime);
        }
         if(Input.GetKey("k"))
        {
             transform.Translate(new Vector3(0, -10, 0) * Time.deltaTime);
        }
       
    }
}
