using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaTipo1 : Bala
{
    public override void Impacto(Collision objetoImpactado)
    {
        Debug.Log("Impacto");
        base.Impacto(objetoImpactado);
    }
}
