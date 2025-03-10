using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class bolo3 : MonoBehaviour
{
    public GameObject cubo,cubo2;
   public  bool bolca;
    private bolo1 bolo1a;
    private bolo2 bolo2a;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        bolo1a = cubo.GetComponent<bolo1>();
        bolo2a = cubo2.GetComponent<bolo2>();   




    }

   
    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (bolo1a.bolc == true && bolo2a.bolci == true)
        {
            this.GetComponent<Renderer>().material.color = Color.white;
            
        }
        else
        {
            this.GetComponent<Renderer>().material.color = Color.black;
       
        }




    }

}
