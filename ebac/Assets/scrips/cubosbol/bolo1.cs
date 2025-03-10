using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class bolo1 : MonoBehaviour
{
    
    bool bolc;
    int val1;
   
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
        val1 = Random.Range(0, 2);
        

        if (val1 == 0)
        {
            bolc = false;
            Debug.Log("val1 is 0");
            Color color = new Color(0,0,0);
            this.GetComponent<Renderer>().material.color = color;
            
        }
        else
        {
            bolc = true;
            Color color = new Color(1,1, 1);
            this.GetComponent<Renderer>().material.color = color;

            Debug.Log("val1 is 1");
            bolc = true;
        }

    }
}
