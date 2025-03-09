using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorfixed : MonoBehaviour
{
  
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
        
       Debug.Log("FixedUpdate: " );
        Color color = new Color(Random.value, Random.value, Random.value);
        this.GetComponent<Renderer>().material.color = color;

    }
}
