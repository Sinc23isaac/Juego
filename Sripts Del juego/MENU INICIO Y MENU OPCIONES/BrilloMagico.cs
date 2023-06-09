using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrilloMagico : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image panelBrillo;


    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("brillo", 0.5f);
        //asi podemos cambiar el color y su trnasparencia por eso dejamos como estaba 
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slider.value);

    }
    void Update()
    {

    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        //guardamos el valor nuevo cuando movemos el slider para los cambios xd
        PlayerPrefs.SetFloat("brillo", sliderValue);
        //aqui cmabiar el slider value del panel
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slider.value);

    }
}
