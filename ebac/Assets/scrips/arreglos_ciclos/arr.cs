using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arr : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] arreglo = new int[5];
        int[] arreglo2 = new int[5];
        int[] arreglo3 = new int[5];
        string[] oracion = new string[4] {"hola","que","haces","pedro" };

        for (int i = 0; i < arreglo.Length; i++)
        {
            arreglo[i] = Random.Range(1,10);
            arreglo2[i] = Random.Range(1, 10);
            arreglo3[i] = arreglo[i] + arreglo2[i];
            Debug.Log("arreglo 3 posicion ("+i+") : "+arreglo3[i]);

        }

        string oracionCompleta = "";
        foreach (string palabra in oracion)
        {
            oracionCompleta += palabra + " ";
        }

        
       Debug.Log(oracionCompleta);


        int[,] matriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[] ints = new int[3] { 7, 6,8};
        int[] resultado = new int[2];

        
        for (int i = 0; i < 2; i++)
        {
            resultado[i] = 0;
            for (int j = 0; j < 3; j++)
            {
                resultado[i] += matriz[i, j] * ints[j];
            }
        }


        Debug.Log("el arreglo de resultado quedaria como: "+"["+resultado[0]+"," + resultado[1]+"]");









        //int[] arreglo = new int[5];
        //string[] semanad = new string[7] { "lunes", "martes", "miercoles", "jueves", "viernes", "sabado", "domingo" };
        //Debug.Log(semanad[0]);
        //Debug.Log(semanad[1]);
        //Debug.Log(semanad[2]);
        //Debug.Log(semanad[3]);
        //Debug.Log(semanad[4]);
        //Debug.Log(semanad[5]);
        //Debug.Log(semanad[6]);

        //for (int i = 0; i < semanad.Length; i++)
        //{
        //    Debug.Log(semanad[i]);
        //}
        //int[,] amatriz = new int[3, 3] {{1,2,3},{4,5,6},{7,8,9} };





        //for (contador = 0; contador < 10; contador++)
        //{
        //    Debug.Log(contador);
        //}
        //while (contador < 10)
        //{
        //    Debug.Log(contador);
        //    contador++;
        //}
        //do
        //{
        //    Debug.Log(contador);
        //    contador++;
        //} while (contador < 10);



    }

    // Update is called once per frame
    void Update()
    {
     
    }
}
