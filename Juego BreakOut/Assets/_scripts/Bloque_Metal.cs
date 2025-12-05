using UnityEngine;

public class Bloque_Metal : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CambioResistencia(8, 16, 24);
        resistencia = 8;
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }

}
