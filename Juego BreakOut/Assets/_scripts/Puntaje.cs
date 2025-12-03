using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntaje : MonoBehaviour
{
    public Transform TransformPuntajeAlto;
    public Transform TransformPuntajeActual;
    public TMP_Text textoPuntajeAlto;
    public TMP_Text textoActual;
    public PuntajeAlto puntajeAltoSO;
    //public int puntos = 0;
    //public int puntajeAlto = 10000;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TransformPuntajeActual = GameObject.Find("PuntajeActual").transform;
        TransformPuntajeAlto = GameObject.Find("PuntajeAlto").transform;
        textoActual = TransformPuntajeActual.GetComponent<TMP_Text>();
        textoPuntajeAlto = TransformPuntajeAlto.GetComponent<TMP_Text>();
        //if (PlayerPrefs.HasKey("puntajeAlto"))
        //{
        //puntajeAlto = PlayerPrefs.GetInt("puntajeAlto");
        //}
        puntajeAltoSO.Cargar();
        textoPuntajeAlto.text = $"puntajeAlto: {puntajeAltoSO.puntajeAlto}";
        puntajeAltoSO.puntaje = 0;
    }

    private void FixedUpdate()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        textoActual.text = $"PuntajeActual: {puntajeAltoSO.puntaje}";
        if (puntajeAltoSO.puntaje > puntajeAltoSO.puntajeAlto)
        {
            puntajeAltoSO.puntajeAlto = puntajeAltoSO.puntaje;
            textoPuntajeAlto.text = $"PuntajeAlto: {puntajeAltoSO.puntajeAlto}";
            puntajeAltoSO.Guardar();
            //PlayerPrefs.SetInt("PuntajeAlto", puntos);
        }
    }

    public void AumentarPuntaje(int puntos)
    {
        puntajeAltoSO.puntaje += puntos;
    }
}
