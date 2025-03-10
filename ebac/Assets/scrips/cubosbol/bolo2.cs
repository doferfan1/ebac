using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class bolo2 : MonoBehaviour
{
    int val1;
    bool bolc=true;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (bolc)
        {
           
            Debug.Log(bolc);
            Color color = new Color(1, 1, 1);
            this.GetComponent<Renderer>().material.color = color;

        }
        else
        {
            
            Color color = new Color(0, 0,0 );
            this.GetComponent<Renderer>().material.color = color;

            Debug.Log(bolc);
            
        }

    }

    // Update is called once per frame
    void Update()
    {


    }
    private void FixedUpdate()
    {
      

    }
}
