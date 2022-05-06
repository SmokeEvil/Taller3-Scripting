using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muro : MonoBehaviour
{
    BoxCollider boxCollider;
    float temporizador;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }
    // Update is called once per frame
    void Update()
    {
        if (!boxCollider.enabled)
        {
            temporizador -= Time.deltaTime;
            if(temporizador <= 0)
            {
                boxCollider.enabled = true;
                Disparador.Instance.puedeDisparar = true;
            }

        }
    }

    public void ApagarCollider()
    {
        temporizador = 1;
        boxCollider.enabled = false;
        Disparador.Instance.puedeDisparar = false;
    }
}
