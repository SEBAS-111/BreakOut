using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFinDeNivel : MonoBehaviour
{
    public void SiguienteNivel()
    {
        var siguenteNivel = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > siguenteNivel)
        {
            SceneManager.LoadScene(siguenteNivel);
        }
        else
        {
            CargarMenuPrincipal();
        }
    }

    public void CargarMenuPrincipal()
    {
        SceneManager.LoadScene(0);
    }

    public void ReintentarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
