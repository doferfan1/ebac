using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

public class practicamod10 : MonoBehaviour
{
    List<int> lista = new List<int>();
    List<int> listados = new List<int>();
    List<String> listacuatro = new List<String>();
    Stack<String> listatres = new Stack<String>();
    Queue<string> listadote = new Queue<string>();
    int h = 0;
    int i = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lista = new List<int> { 3, 9, 5, 2, 1, 10 };
        listados = new List<int> { 9, 9, 5, 2, 2, 10 };
        listatres = new Stack<String>();
        listacuatro = new List<String> { "hola", "adios", "que", "paso", "nino", "perro" };
        
        paruno(5, 4, 23);
        pardos(lista);
        partre(listados);
        foreach (string item in listacuatro)
        {
           
            Debug.Log("palabra: " + listacuatro[i]);
            listatres.Push(item);
            i++;

        }
        parcu(listatres);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void pardos(List<int> lista)
    {
        var listaordenada = lista.OrderByDescending(x => x).ToList();
        for (int i = 0; i < lista.Count; i++)
        {
            h++;
            Debug.Log("numero " + h + " de la lista: " + listaordenada[i]);
        }
    }


    public void paruno(int x, int y, int z)
    {
        int g;

        for (int i = 0; i < x; i++)
        {
            g = Random.Range(y, z);
            lista.Add(g);
        }

        for (int i = 0; i < lista.Count; i++)
        {
            h++;

            Debug.Log("numero " + h + " de la lista: " + lista[i]);
        }


    }


    public void partre(List<int> listad)
    {
        HashSet<int> hash = new HashSet<int>();

        foreach (int i in listad)
        {

            hash.Add(i);
        }


        foreach (int item in hash)
        {
            h++;
            Debug.Log("numero " + h + " del HashSet: " + item);
        }
    }


    public void parcu(Stack<String> listado)
    {
      

        foreach (string palabra in listado)
        {
           
            listadote.Enqueue(listado.Peek());
            listado.Pop();
            Debug.Log("palabra: " + listadote.Peek());
            listadote.Dequeue();

        }


     
    }
}
