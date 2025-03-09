using System.Collections;
using System.Collections.Generic;

using UnityEngine.UIElements;
using UnityEngine;

public class cuboondis : MonoBehaviour
{
    public GameObject punto;
    public GameObject cube;
    public List<GameObject> lcubos;
    public float factores;
    public int numcub = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        lcubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDisable()
    {

        numcub++;
        GameObject tempcube = Instantiate<GameObject>(cube);

        tempcube.name = "cubolos" + numcub;
        Color color = new Color(Random.value, Random.value, Random.value);
        tempcube.GetComponent<MeshRenderer>().material.color = color;

        tempcube.transform.position = punto.transform.position;

    }

    private void OnEnable()
    {

        numcub++;
        GameObject tempcube = Instantiate<GameObject>(cube);

        tempcube.name = "cubolos" + numcub;
        Color color = new Color(Random.value, Random.value, Random.value);
        tempcube.GetComponent<MeshRenderer>().material.color = color;

        tempcube.transform.position = punto.transform.position;

    }
}
