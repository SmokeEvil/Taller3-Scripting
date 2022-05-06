using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bala : MonoBehaviour
{
    public Pool pool;

    Rigidbody rigidbodyBala;

    private void Awake()
    {
        rigidbodyBala = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        Configuracion();
        rigidbodyBala.AddForce(Vector3.right * 300);
    }

    public virtual void Configuracion()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Impacto(collision);
    }

    public virtual void Impacto(Collision objetoImpactado)
    {
        pool.ReciclarObjeto(this);
    }
}
