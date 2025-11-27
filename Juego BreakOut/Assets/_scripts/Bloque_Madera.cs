using UnityEngine;

public class Bloque_Madera : Bloque
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        resistencia = 3;
    }

    public override void RebotarBola(Collision collision)
    {
        base.RebotarBola(collision);
    }
}
