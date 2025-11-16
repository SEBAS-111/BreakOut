using System;
using UnityEngine;

public class MuestraSuscriptor : MonoBehaviour
{
    MuestraEventos subscriptor;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        subscriptor = GetComponent<MuestraEventos>();
        subscriptor.OnSpacePressed += MensajeEscuchadoPorElsubscriptor;
    }

    // Update is called once per frame
    private void MensajeEscuchadoPorElsubscriptor(object sender, EventArgs e)
    {
        Debug.Log("el evento ha sido Escuchado desde otra Clase");
        subscriptor.OnSpacePressed -= MensajeEscuchadoPorElsubscriptor;
    }
}
