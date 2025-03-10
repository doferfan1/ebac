using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class bolo4 : MonoBehaviour
{
    public GameObject cubo, cubo2;
    public bool bolc;
    private bolo1 bolo1a;
    private bolo2 bolo2a;
    // Referencia al otro objeto

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
        if (bolo1a.bolc || bolo2a.bolci)
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