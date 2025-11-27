using UnityEngine;
using UnityEngine.UI;

public class SliderVelocidad : MonoBehaviour
{
    public Opciones opciones;

    Slider slider;
    public void Start()
    {
        slider = this.GetComponent<Slider>();
        slider.onValueChanged.AddListener(delegate { controlCambios(); });
    }

    public void controlCambios()
    {
        opciones.CambiarVelocidad(slider.value);
    }

}
