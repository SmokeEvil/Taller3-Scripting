using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparador : MonoBehaviour
{
    private static Disparador instance;

    Pool pool1;
    Pool pool2;
    Pool pool3;

    int seleccionada = 1;

    public bool puedeDisparar;

    public static Disparador Instance { get => instance; private set => instance = value; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        pool1 = GetComponent<PoolTipo1>();
        pool2 = GetComponent<PoolTipo2>();
        pool3 = GetComponent<PoolTipo3>();

        puedeDisparar = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && puedeDisparar)
            Disparar(seleccionada);

        if (Input.GetMouseButtonDown(1))
            CambiarSeleccion();
    }

    void Disparar(int seleccion)
    {
        GameObject obj = null;
        switch (seleccion)
        {
            case 1: obj = pool1.UsarObjeto();
                obj.transform.position = transform.position;
                break;
            case 2:
                 obj = pool2.UsarObjeto();
                obj.transform.position = transform.position;
                break;
            case 3:
                 obj = pool3.UsarObjeto();
                obj.transform.position = transform.position;
                break;
        }
    }

    void CambiarSeleccion()
    {
        seleccionada++;
        if(seleccionada > 3)
            seleccionada = 1;
    }
}
