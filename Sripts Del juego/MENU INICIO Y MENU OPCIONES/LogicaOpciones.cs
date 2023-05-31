using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaOpciones : MonoBehaviour
{
    //referencia al codigo de controlador opciones
    public ControlOpcioes panelOpciones;
    // Start is called before the first frame update
    void Start()
    {
        //que saque el codigo de controladores
        //mostrar opciones
        panelOpciones = GameObject.FindGameObjectWithTag("nuevaOpcion").GetComponent<ControlOpcioes>();
    }

    // Update is called once per frame
    void Update()
    {
        //si quieres que no pase nada x el scape
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MostrarOpciones();
        }
    }

    public void MostrarOpciones()
    {
        
        panelOpciones.pantallaOpciones.SetActive(true);
    }
}
