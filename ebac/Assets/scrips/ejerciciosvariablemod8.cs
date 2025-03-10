using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejerciciosvariablemod8 : MonoBehaviour
{
    public GameObject cubo;
    int a=1;
    float b=1.5f;
    float c = 3.2f;
    int d,r;
    string op;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        d=(int)b+ (int)c;
        Debug.Log("d: " + d);
        r = 1;
        float numero = 123.456789f;
        string cuatrod = numero.ToString("F4");
        Debug.Log("Número con 4 decimales: " + cuatrod);
        string nombreCompleto = "Juan Carlos Pérez";

        
        string primerNombre = nombreCompleto.Substring(0, 4); 
        string segundoNombre = nombreCompleto.Substring(5, 6); 
        string apellido = nombreCompleto.Substring(12); 

        Debug.Log("Primer Nombre: " + primerNombre);
        Debug.Log("Segundo Nombre: " + segundoNombre);
        Debug.Log("Apellido: " + apellido);

       
        string[] partesNombre = nombreCompleto.Split(' ');

        foreach (string parte in partesNombre)
        {
            Debug.Log("Parte del nombre: " + parte);
        }
    }

    // Update is called once per frame
    void Update()
    {
        a *= 2;
        Debug.Log("a: " + a);
    }

    private void FixedUpdate()
    {
        b *= 2;
        Debug.Log("b: " + b);
        r++;
        if (r % 2 == 0)
        {
            Debug.Log("es par: " + r);
        
            this.GetComponent<Renderer>().material.color = Color.red;
            op = "par";
        }
        else
        {
            Debug.Log("es impar: " + r);
            this.GetComponent<Renderer>().material.color = Color.blue;
            op = "impar";
        }
        switch(op)
        {
            case "par":
                cubo.GetComponent<Renderer>().material.color = Color.white;
                Debug.Log("es par: " + r);
                break;

            case "impar":
                cubo.GetComponent<Renderer>().material.color = Color.black;
                Debug.Log("es impar: " + r);
                break;

            default:
                Debug.Log("no es par ni impar: " + r);
                break;
        }
    }
}
