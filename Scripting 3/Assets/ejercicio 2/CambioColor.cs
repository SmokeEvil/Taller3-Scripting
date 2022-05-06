using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    [SerializeField]
    Color color1;

    [SerializeField]
    Color color2;

    [SerializeField]
    Color color3;

    [SerializeField]
    Color color4;

    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        DetectorClicks.Instance.OnButtonClicked += CambiarColor;
    }

    public void CambiarColor(int selector)
    {
        switch (selector)
        {
            case 1: rend.material.color = color1; 
                break;
            case 2: rend.material.color = color2;
                break;
            case 3: rend.material.color = color3;
                break;
            case 4: rend.material.color = color4;
                break;
        }
    }

}
