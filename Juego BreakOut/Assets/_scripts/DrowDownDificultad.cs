using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DrowDownDificultad : MonoBehaviour
{
    public Opciones opciones;
    private TMP_Dropdown Dificultad;

    private void Start()
    {
        Dificultad = this.GetComponent<TMP_Dropdown>();
        Dificultad.onValueChanged.AddListener(delegate { opciones.CambiarDificultad(Dificultad.value); });
    }
}
