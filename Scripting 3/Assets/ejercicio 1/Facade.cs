using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Facade : MonoBehaviour
{
    private static Facade instance;

    public static Facade Instance { get => instance; private set => instance = value; }

    Factory factoryTipo1;
    Factory factoryTipo2;
    Factory factoryTipo3;

    int seleccion;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        factoryTipo1 = GetComponent<FactoryTipo1>();
        factoryTipo2 = GetComponent<FactoryTipo2>();
        factoryTipo3 = GetComponent<FactoryTipo3>();
    }

    public void CambiarSeleccion(int seleccion)
    {
        this.seleccion = seleccion;
    }

    public void Instanciar()
    {
        GameObject gameObject = null;
        switch (seleccion)
        {
            case 0: gameObject = factoryTipo1.ObtenerObjeto();
                break;
            case 1: gameObject = factoryTipo2.ObtenerObjeto();
                break;
            case 2: gameObject = factoryTipo3.ObtenerObjeto();
                break;
        }
        gameObject.transform.position = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0);

    }
}
