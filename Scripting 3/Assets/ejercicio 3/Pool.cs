using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pool : MonoBehaviour
{
    [SerializeField]
    Bala Prefab;

    [SerializeField]
    int Tama�o;

    List<Bala> listaBalas = new List<Bala>();

    private void Awake()
    {
        RellenarPool(Tama�o);
    }
    void RellenarPool(int tama�o)
    {
        for (int i = 0; i < tama�o; i++)
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
