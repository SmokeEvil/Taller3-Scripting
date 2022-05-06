using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaTipo3 : Bala
{
    public override void Impacto(Collision objetoImpactado)
    {
        if (objetoImpactado.gameObject.name == "Muro")
            objetoImpactado.gameObject.GetComponent<Muro>().ApagarCollider();
        base.Impacto(objetoImpactado);
    }
}
