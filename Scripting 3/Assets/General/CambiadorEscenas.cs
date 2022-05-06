using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiadorEscenas : MonoBehaviour
{
    [SerializeField]
    string Escena;

    public void CambiarDeEscena()
    {
        SceneManager.LoadScene(Escena);
    }
}
