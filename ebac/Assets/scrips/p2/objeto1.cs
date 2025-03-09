using System.Collections;
using System.Collections.Generic;   
using UnityEngine;

public class objeto1 : MonoBehaviour
{

    GameObject newob;

    Vector3[] vertices =
    {
        new Vector3(0, 0, 0),
        new Vector3(1, 0, 0),
        new Vector3(1, 1, 0),
        new Vector3(0, 1, 0),
        new Vector3(0, 1, 1),
        new Vector3(1, 1, 1),
        new Vector3(1, 0, 1),
        new Vector3(0, 0, 1),

    };

    int[] triangulos =
    {
        0, 2, 1,
        0, 3, 2,
        2, 3, 4,
        2, 4, 5,
        1, 2, 5,
        1, 5, 6,
        0, 7, 4,
        0, 4, 3,
        5, 4, 7,
        5, 7, 6,
        0, 6, 7,
        0, 1, 6,
    };



    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        newob = new GameObject("newob");
        newob.AddComponent<MeshFilter>();
        var mesfilter =newob.GetComponent<MeshFilter>().mesh;
        mesfilter.Clear();
        mesfilter.vertices = vertices;
        mesfilter.triangles = triangulos;
        mesfilter.Optimize();
        mesfilter.RecalculateNormals();
        newob.AddComponent<BoxCollider>();
        var boxes= newob.GetComponent<BoxCollider>();
        boxes.center = new Vector3(0.5f, 0.5f, 0.5f);
        newob.AddComponent<MeshRenderer>();
        var meshcol = newob.GetComponent<MeshRenderer>().material;
       meshcol.color = Color.white;


        newob.transform.position = new Vector3(1, 1, 1);





    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
