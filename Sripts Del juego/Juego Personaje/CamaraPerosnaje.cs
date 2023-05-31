using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraPerosnaje : MonoBehaviour
{
    //declaramos variables que vamos a utilizar
    //sensibilidad del movimiento del raton 
    public float sensitivity = 100f;
    //referencias del personaje
    public Transform player;

    //la rotacion  del eje x para ponerlo en 0 
    private float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //preguntar cuando estamos rotando si es el eje X o Y
        //con esto veremos cuando se meueve en el eje X y guardamos en float
        //el time.deltatime  sirve para la velocidad si tiene mas fps xd
        float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
       
        //movimiento de la camara si es + llama a la camara inversa
        xRotation -= mouseY;
        //que nuestra camara no valla ni muy alto ni muy abajo que no traspace de -90 hasta 90
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        //rotar el personaje hacemos referencia para que rote con la camara
        player.Rotate(Vector3.up * mouseX);
    }
}
