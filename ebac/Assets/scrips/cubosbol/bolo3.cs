using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class bolo3 : MonoBehaviour
{
    public GameObject cubo,cubo2;
    bool bolc;
    

// Start is called once before the first execution of Update after the MonoBehaviour is created
void Start()
    {





        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        Color color = new Color(1, 1, 1);
        Color color2 = new Color(0, 0, 0);
       
        Color color3= new Color(cubo.GetComponent<Renderer>().material.color.r, cubo.GetComponent<Renderer>().material.color.g, cubo.GetComponent<Renderer>().material.color.b);
        Color color4 = new Color(cubo2.GetComponent<Renderer>().material.color.r, cubo2.GetComponent<Renderer>().material.color.g, cubo2.GetComponent<Renderer>().material.color.b);
        if (color3 == color && color2==color4)
        {
          this.GetComponent<Renderer>().material.color = color;
        }
        else
        {
            this.GetComponent<Renderer>().material.color = color2;
        }




    }
}
