using UnityEngine;

public class boolas : MonoBehaviour
{
    bool bol1;
    bool bol2;
    bool bol3;
    int val1=5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bol1 = true;
        bol2 = false;
        if (!bol1)
        {
            Debug.Log("bol1 is false");
        }
        else
        {
            Debug.Log("bol1 is true");
        }
        if(val1 == 5)
        {
            Debug.Log("val1 is 5");
        }
        else
        {
            Debug.Log("val1 is not 5");
        }
        if (bol1 && bol2)
        {
            Debug.Log("bol1 and bol2 are true");
        }
        else
        {
            Debug.Log("bol1 and bol2 are not true");
        }
        if (bol1 || bol2)
        {
            Debug.Log("bol1 or bol2 is true");
        }
        else
        {
            Debug.Log("bol1 or bol2 is not true");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
