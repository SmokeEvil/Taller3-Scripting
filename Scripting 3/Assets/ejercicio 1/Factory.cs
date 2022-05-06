using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Factory : MonoBehaviour
{
    [SerializeField]
    GameObject prefab;

    public GameObject ObtenerObjeto()
    {
        GameObject gameObject = Instantiate(prefab);
        return gameObject;
    }
}
