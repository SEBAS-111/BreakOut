using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AdministradorDePersistencia : MonoBehaviour
{
    public List<PuntajePersistente> ObjetoAGuardar;
    public void OnEnable()
    {
        for (int i = 0; i < ObjetoAGuardar.Count; i++)
        {
            var so = ObjetoAGuardar[i];
            so.Cargar();
        }
    }


    public void OnDisable()
    {
        for (int i = 0; i < ObjetoAGuardar.Count; i++)
        {
            var so = ObjetoAGuardar[i];
            so.Guardar();
        }
    }
}
