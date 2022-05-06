using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaTipo2 : Bala
{
    [SerializeField]
    ParticleSystem particles;

    public override void Configuracion()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = true;
    }

    public override void Impacto(Collision objetoImpactado)
    {
        particles.Play();
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        Invoke("Reciclar", 1);
    }

    void Reciclar()
    {
        pool.ReciclarObjeto(this);
    }
}
