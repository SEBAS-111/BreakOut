using UnityEngine;

public class Bloque_Vidrio : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CambioResistencia(2, 4, 6);
        
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }

}
