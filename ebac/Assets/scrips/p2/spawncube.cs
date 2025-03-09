using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class spawncube : MonoBehaviour
{
    public GameObject cube;
    public List<GameObject> lcubos;
    public float factores;
    public int numcub=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lcubos = new List<GameObject>();



    }

    // Update is called once per frame
    void Update()
    {
        numcub++;
        GameObject tempcube = Instantiate<GameObject>(cube);

        tempcube.name = "cubo" + numcub;
        Color color = new Color(Random.value, Random.value, Random.value);
        tempcube.GetComponent<MeshRenderer>().material.color = color;

        tempcube.transform.position = Random.insideUnitSphere;
        lcubos.Add(tempcube);
        

        List<GameObject> cuboselim = new List<GameObject>();
        foreach (GameObject cubol in lcubos)
        {

            
            float scale = cubol.transform.localScale.x;
            scale *= factores;
            cubol.transform.localScale = new Vector3(1 * scale, 1* scale, 1 * scale);
            if (scale <=.1)
            {
                cuboselim.Add(cubol);
         
            }
        }
        foreach (GameObject cubol in cuboselim)
        {
            lcubos.Remove(cubol);
            Destroy(cubol);
        }





    }
}
