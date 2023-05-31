using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class ObjetosColeccionable : MonoBehaviour
{
    //ESTO ES PARA LAS MONEDAS AL ZAR EN UN CIERTO RANGO DEL MAPA
    //declaro 
    //hace  referencia a un objeto específico en la escena de Unity,
    public GameObject Monedas;
    private bool hasSpawned = false; // variable para saber si ya se han creado las monedas




    // Update is called once per frame
    void Update()
    {
        Vector3 Min;
        Vector3 Max;
        float _xAxis;
        float _yAxis;
        float _zAxis;
        Vector3 randomPosition;

        //cuando presione la tecla P apareceran las monedas es como el codigo del ejemplo
        //donde presionas en cambio la tecla L 
        if (Input.GetKeyDown(KeyCode.P))
        {


            //esto es para la cantidad de monedad que van a caer xd
            for (int i = 0; i < 50; i++)
            {
                //aqui sera desde donde quieres que empiezen a caer monedas nahh que tonto soy xd
                Min = new Vector3(102, 50, -115);
                //X, Y, Z 
                //z es la distancia en ancho que recorre
                //x es lo largo que recorre todo eso xd 
                //esta parte seria mas o menos de que distancias estan las monedas es decir la atura y eso 
                Max = new Vector3(250, 50, -29);
                //lo de arriba seria desde donde van a parecer y ese rolloxd en otras palabra la posicion


                _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
                _yAxis = UnityEngine.Random.Range(Min.y, Max.y);
                _zAxis = UnityEngine.Random.Range(Min.z, Max.z);
                randomPosition = new Vector3(_xAxis, _yAxis, _zAxis);
                var una = Instantiate(Monedas, randomPosition, Quaternion.identity);


            }


        }
    }

}

