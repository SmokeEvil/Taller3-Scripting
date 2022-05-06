using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class DetectorClicks : MonoBehaviour
{
    private static DetectorClicks instance;

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
    }

    public event Action<int> OnButtonClicked;
    int valor;

    public static DetectorClicks Instance { get => instance; private set => instance = value; }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            if (OnButtonClicked != null)
                OnButtonClicked.Invoke(Valor());
    }

    private int Valor()
    {
        valor++;
        if (valor > 4)
            valor = 1;
        return valor;
    }
}
