using UnityEngine;

public class Bloque_Piedra : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CambioResistencia(5, 10, 15);
        
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }

}
