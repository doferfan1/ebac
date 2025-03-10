using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolo4 : MonoBehaviour
{
    public GameObject cubo;
    float r, g, b;
    // Referencia al otro objeto

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
       r = cubo.GetComponent<Renderer>().material.color.r;
        g = cubo.GetComponent<Renderer>().material.color.g;
        b = cubo.GetComponent<Renderer>().material.color.b;
        Color color1 = new Color(r, g, b);
        Color color = new Color(1, 1, 1);
       Color color4 = new Color(0, 0, 0);

        this.GetComponent<Renderer>().material.color = (color1 == color) ? color4 : color;

        

    }
}