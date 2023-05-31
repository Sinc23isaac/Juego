using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CalidadLogica : MonoBehaviour
{
    //es eso de donde ponemos los dropdwon para elegir la caliad
    public TMP_Dropdown dropdown;
    //esto es para cmabiar el valor para elegir el valor de downo
    public int calidad;
    // Start is called before the first frame update
    void Start()
    {
        //forma de guardar un valro y utilizarlo el playerprefer
        calidad = PlayerPrefs.GetInt("numeroDeCalidad", 3);//recuarda que la calidad comienza desde 0 xd
        dropdown.value = calidad;
        AjustarCalidad();

    }

    // Update is called once per frame
    void Update()
    {

    }
    //esto es donde cambiara el numero es decir la caliad que queramos

    public void AjustarCalidad()
    {
        QualitySettings.SetQualityLevel(dropdown.value);
        PlayerPrefs.SetInt("numeroDeCalidad", dropdown.value);
        calidad = dropdown.value;
    }
}
