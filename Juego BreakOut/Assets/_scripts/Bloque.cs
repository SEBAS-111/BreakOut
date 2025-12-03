using System;
using UnityEngine;
using UnityEngine.Events;

public class Bloque : MonoBehaviour
{
    public int resistencia = 1;
    public Opciones opciones;
    public UnityEvent AumentarPuntaje;


    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            RebotarBola(collision);
        }
    }

    public virtual void RebotarBola(Collision collision)
    {
        Vector3 direccion = collision.contacts[0].point - transform.position;
        direccion = direccion.normalized;
        collision.rigidbody.linearVelocity = collision.gameObject.GetComponent<bola>().velocidadBola * direccion;
        resistencia--;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (opciones.NivelDificultad)
        {
            case Opciones.Dificultad.facil:
                resistencia = 100;
                break;
            case Opciones.Dificultad.normal:
                resistencia = 200;
                break;
            case Opciones.Dificultad.dificil:
                resistencia = 300;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (resistencia <= 0)
        {
            AumentarPuntaje.Invoke();
            Destroy(this.gameObject);
        }
    }

    public virtual void RebotarBola()
    {

    }


}
