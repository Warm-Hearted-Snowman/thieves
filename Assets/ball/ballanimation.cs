using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ballanimation : MonoBehaviour
{
    public UnityEvent  OnCollisionEvent ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) 
    {
        OnCollisionEvent?.Invoke();
    }
}
