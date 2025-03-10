using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class bolo1 : MonoBehaviour
{
    
   public bool bolc;
    
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    private void FixedUpdate()
    {
        
        

        if (bolc)
        {
           
            
            this.GetComponent<Renderer>().material.color = Color.white;
            bolc = false;
        }
        else
        {
            this.GetComponent<Renderer>().material.color = Color.black;
            bolc = true;
        }

    }
}
