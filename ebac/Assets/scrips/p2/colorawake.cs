using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorawake : MonoBehaviour
{
    public GameObject punto;
    public GameObject cube;

    void Awake()
    {

        Color color = new Color(Random.value, Random.value, Random.value);
        cube.GetComponent<Renderer>().material.color = color;
        

    }   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
