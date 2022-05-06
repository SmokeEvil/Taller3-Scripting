using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DetectorClicks.Instance.OnButtonClicked += ImprimirValor;
    }

    void ImprimirValor(int valor)
    {
        Debug.Log(valor);
    }
}
