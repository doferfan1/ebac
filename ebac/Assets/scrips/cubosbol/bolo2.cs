using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class bolo2 : MonoBehaviour
{
   
   public bool bolci;
    

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

        if (bolci)
        {


            this.GetComponent<Renderer>().material.color = Color.white;
            bolci = false;
        }
        else
        {
            this.GetComponent<Renderer>().material.color = Color.black;
            bolci = true;
        }
    }
}
