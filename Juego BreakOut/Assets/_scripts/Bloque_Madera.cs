using UnityEngine;

public class Bloque_Madera : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CambioResistencia(3, 6, 9);
        resistencia = 3;
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}
