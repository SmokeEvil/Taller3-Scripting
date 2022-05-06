using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pool : MonoBehaviour
{
    [SerializeField]
    Bala Prefab;

    [SerializeField]
    int Tamaño;

    List<Bala> listaBalas = new List<Bala>();

    private void Awake()
    {
        RellenarPool(Tamaño);
    }
    void RellenarPool(int tamaño)
    {
        for (int i = 0; i < tamaño; i++)
        {
            CrearObjeto();
        }
    }

    void CrearObjeto()
    {
        Bala bala = Instantiate(Prefab);
        bala.pool = this;
        bala.gameObject.SetActive(false);
        listaBalas.Add(bala);
    }

    public GameObject UsarObjeto()
    {
        Bala bala;
        if(listaBalas.Count <= 0)
        {
            CrearObjeto();
        }
        bala = listaBalas[listaBalas.Count - 1];
        listaBalas.Remove(bala);
        bala.gameObject.SetActive(true);
        return bala.gameObject;
    }

    public void ReciclarObjeto(Bala bala)
    {
        listaBalas.Add(bala);
        bala.gameObject.SetActive(false);
    }



}
