using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    //declaro variables
    //referencia al caracter controlador
    public CharacterController controlador;

    //velocidad que vamos a tener al movernos
    public float speed = 10f;

    //gravedad de la tierra 
    //razon de porque el - 
    public float gravedad = -9.8f;

    //saltar con el personaje
    public float saltoAlto = 3;

    //Varibale que detecte si esta tocando el suelo
    //es un objeto de tipo Transform que se utiliza como referencia para comprobar si el personaje está en contacto con el suelo. 
    public Transform groudcheck;

    //es la distancia máxima a la que se buscará el suelo desde la posición 
    public float groundDistance = 0.3f;

    //es una máscara de capas que se utiliza para filtrar los objetos que se considerarán como suelo. 
    public LayerMask groundMask;

    //Velocidad personaje
    Vector3 velocidad;
    //si estamos en el suelo o no
    bool isgrounded;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //aqui sera la parte del cuando hagamos algo xd
        //probar si estamos en el suelo o no si si da true es xq estamos en el suelo
        isgrounded = Physics.CheckSphere(groudcheck.position, groundDistance, groundMask);

        //si estamos en el suelo el eje Y
        if (isgrounded && velocidad.y < 0)
        {
            //f de float
            velocidad.y = -2f;
        }

        //flecha izquiera movimiento horizontal
        float x = Input.GetAxis("Horizontal");
        //flecha arriba o abajo
        float z = Input.GetAxis("Vertical");

        //vector3 que le decimos como queremos movernos
        Vector3 move = transform.right * x + transform.forward * z;
        //que se mueva con lo que vereficamos

        controlador.Move(move * speed * Time.deltaTime);
        //cuando querremos saltar

        if (Input.GetButtonDown("Jump") && isgrounded)
        {
            //salto formula de fisica
            velocidad.y = Mathf.Sqrt(saltoAlto * -2 * gravedad);
        }
        velocidad.y += gravedad * Time.deltaTime;

        controlador.Move(velocidad * Time.deltaTime);
    }
}
