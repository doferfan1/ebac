using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class bolo5 : MonoBehaviour
{

    public GameObject cubo,cubo2,cubo3;
    public bool bolca;
    private bolo3 bolo1a;
    private bolo4 bolo2a;
    private bolo2 bolo3a;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bolo1a = cubo.GetComponent<bolo3>();
        bolo2a = cubo2.GetComponent<bolo4>();
        bolo3a = cubo3.GetComponent<bolo2>();

    }
    private void FixedUpdate()
    {
        if ((bolo1a.bolca==true||bolo2a.bolc == true) && bolo3a.bolci==true)
        {
            this.GetComponent<Renderer>().material.color = Color.white;
            bolca = false;

        }
        else
        {
            this.GetComponent<Renderer>().material.color = Color.black;
            bolca = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
