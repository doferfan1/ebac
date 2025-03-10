using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorupdate : MonoBehaviour
{
    public GameObject esfera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update " );
        Color color = new Color(Random.value, Random.value, Random.value);
       esfera.GetComponent<Renderer>().material.color = color;

    }
}
