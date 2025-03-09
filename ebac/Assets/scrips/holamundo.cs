using UnityEngine;
using System.Collections;
using System.Collections.Generic;   
public class holamundo: MonoBehaviour
{
    int x;
    void Start()
    {
      //  x = 0;
      //  Debug.Log("hola mundo");
      //  print("print");
      //  Debug.LogWarning("hola mundo");
      //  Debug.LogError("hola mundo");

    }

    void Update()
    {
        //  x = x + 1;
        //  Debug.Log(x);
        Debug.Log("hola mundo");
    }

    private void FixedUpdate()
    {
        Debug.LogWarning("hola fixed 50 frames");
    }


    private void LateUpdate()
    {
        Debug.LogWarning("hola late ");
    }

    private void OnEnable()
    {
        Debug.LogWarning("hola el obejto ha sido habilitado");
    }

    private void OnDisable()
    {
        Debug.LogWarning("hola el objeto ha sido deshabilitado");
    }
}

