using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class FullScreen : MonoBehaviour
{
    //es la casilla pantalla completa
    public Toggle tooggle;

    //
    public TMP_Dropdown resolucionesDropdown;
    //guarda o mira que tipo de resolution tiene la compu xd
    //las hara automaticamente xd
    Resolution[] resoluciones;
    // Start is called before the first frame update
    void Start()
    {
        //se mirara si esta en metodo ventana o pantalla completa
        if (Screen.fullScreen)
        {
            //esto es si es verdadero o falso
            tooggle.isOn = true;
        }
        else
        {
            //si esta en ventana completa se pondra en falso
            tooggle.isOn = false;
        }
        //revisa resolucion
        RevisarResolucion();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ActivarPantallCompleta(bool pantallaCompleta)
    {
        //si es true se pondra ventana pantalla completa
        Screen.fullScreen = pantallaCompleta;
    }

    public void RevisarResolucion()
    {
        //va a guardar todos las resoluciones de la pantalla de tu compu ordenador
        resoluciones = Screen.resolutions;
        //con esto borra lo de opcion A B y C 
        resolucionesDropdown.ClearOptions();
        //aqui crea una lista donde se va a guardadr el tamaña de la resolucion
        List<string> opciones = new List<string>();
        //variable entero 
        int resolucionActual = 0;
        //mientras mas resoluciones haya se va a repetir esas veces 
        for (int i = 0; i < resoluciones.Length; i++)
        {
            //aqui saca la anchura por la altura y se guarda asi 
            string opcion = resoluciones[i].width + "x" + resoluciones[i].height;
            opciones.Add(opcion);
            //esta opcion que se creo de opcion es una lina que se guarda aqui

            //revisa si la opcion es guardado es la que tenemos actualmente en nuestro juego de la resolucion 
            if (Screen.fullScreen && resoluciones[i].width == Screen.currentResolution.width && resoluciones[i].height ==
                Screen.currentResolution.height)
            {
                resolucionActual = i;

            }
        }
        //agregar las opciones que ha guardado en esta lista
        resolucionesDropdown.AddOptions(opciones);
        //aqui detecta en que resolucion nos encontramos y se pondra que resolucion esta
        resolucionesDropdown.value = resolucionActual;
        //esto se actualizara la lista que tenemos guardado
        resolucionesDropdown.RefreshShownValue();

        //
        resolucionesDropdown.value = PlayerPrefs.GetInt("numeroResolucion", 0);

    }

    //cuando cambiemos a despegable 
    public void CambiarResolucion(int indiceResolucion)
    {
        //Psd tiene que tener el mismo nombre y cambiar el valor y se va a guardar el numero de resoluciones

        //para que guarde el valor de la resolucion 

        PlayerPrefs.SetInt("numeroResolucion", resolucionesDropdown.value);

        Resolution resolucion = resoluciones[indiceResolucion];
        //boolenao para detecta si es pantalla completa o no
        Screen.SetResolution(resolucion.width, resolucion.height, Screen.fullScreen);
    }
}
