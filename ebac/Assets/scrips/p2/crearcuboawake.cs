using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crearcuboawake : MonoBehaviour
{
    public GameObject punto;
    public GameObject cube;
    int numcub = 0;

    private void Awake()
    {
        numcub++;
        GameObject tempcube = Instantiate<GameObject>(cube);

        tempcube.name = "cubolos" + numcub;
        Color color = new Color(Random.value, Random.value, Random.value);
        tempcube.GetComponent<MeshRenderer>().material.color = color;

        tempcube.transform.position = punto.transform.position;
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
