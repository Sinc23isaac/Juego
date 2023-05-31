using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//esto se pone en el personaje
public class Ejemplo : MonoBehaviour
{
    //TODO EL TRABAJO DE CREAR AL AZAR LAS MONEDAS Y COLISIONARLAS CON EL PERSONAJE PARA QUE SE
    //DESTRUYAN Y SE SUMEN 
    public int coinCount;
    public Text TextoMonedas;
    public GameObject Monedas;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            //se suman 
            coinCount++;
            //y aparecenran en el text que hemos creado y asignado a esto
            TextoMonedas.text = coinCount.ToString();
            Debug.Log(TextoMonedas.text);

          

            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        Vector3 Min = new Vector3(-40, 60, 90);
        Vector3 Max = new Vector3(300, 60, 340);

        //cuando presione esta tecla L se empezara a caer moneda desde la posicion asiganada
        //que hemos indicao arriba 
        if (Input.GetKeyDown(KeyCode.L))
        {
            //esto es para la cantidad de monedad que van a caer xd
            for (int i = 0; i < 100; i++)
            {
                float _xAxis = UnityEngine.Random.Range(Min.x, Max.x);
                float _yAxis = UnityEngine.Random.Range(Min.y, Max.y);
                float _zAxis = UnityEngine.Random.Range(Min.z, Max.z);
                Vector3 randomPosition = new Vector3(_xAxis, _yAxis, _zAxis);
                Instantiate(Monedas, randomPosition, Quaternion.identity);
             

            }
        }
    }

}
