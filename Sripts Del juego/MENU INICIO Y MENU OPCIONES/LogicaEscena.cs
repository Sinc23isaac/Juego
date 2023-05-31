using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaEscena : MonoBehaviour
{
    //una funcion que es la misma para pasar entre escena 
    private void Awake()
    {
        //es igual al objeto logia entre escena 
        var noDestruirEscenas = FindObjectsOfType<LogicaEscena>();
        if (noDestruirEscenas.Length > 1)
        {
            Destroy(gameObject);
            return;
        }
        //esto es para el objeto y es para donde vaya una objeto se destruya y no haya duplicado
        DontDestroyOnLoad(gameObject);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
