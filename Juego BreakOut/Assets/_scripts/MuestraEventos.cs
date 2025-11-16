using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class MuestraEventos : MonoBehaviour
{
    public UnityEvent MiEventoUnity;
    public event EventHandler OnSpacePressed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnSpacePressed += EventoEscuchado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed.Invoke(this, EventArgs.Empty);
            MiEventoUnity.Invoke();
        }
    }

    public void EventoEscuchado(object Sender, EventArgs e)
    {
        Debug.Log("el evento se ecucho correctamente");
    }

    public void EventoUnityDisparado()
    {
        Debug.Log("El Evento Unity se disparo correctamente");
    }
}
