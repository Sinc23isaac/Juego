using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volumen : MonoBehaviour
{
    //Declaro variables
    public Slider slider;
    public float sliderValue;
    public Image imagenMute;
    //empieza y se llama antes de la primera actualización del cuadro
    private void Start()
    {
        //creo valor para guardar la psocion donde se encuentra nuestro slider
        //y se guarde siempre de nuestro volumen slider
        //es decir que nuestro sonido empezara con 0.5
        slider.value = PlayerPrefs.GetFloat("VolumenAudio", 0.5f);
        //sacamos el volumen del juego y tendra el valor inicial 
        //va desde 0 al 1
        AudioListener.volume = slider.value;
        //funcion revisar si el volumen muteado o no 
        RevisarSiEstoyMute();

    }
    //principal
    public void ChangeSlider(float valor)
    {
        //este sera el valor del volumen 
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        //sea el valor del valor slider
        AudioListener.volume = slider.value;
        RevisarSiEstoyMute();
    }

    public void RevisarSiEstoyMute()
    {
        if (sliderValue == 0)
        {
            imagenMute.enabled = true;

        }
        else
        {
            imagenMute.enabled = false;

        }
    }
}
