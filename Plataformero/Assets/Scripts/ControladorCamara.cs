using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    public Personaje cavernicola;
    void Start()
    {
        cavernicola = GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {

        bool puedoMoverme = cavernicola.estaVivo() && !cavernicola.bloqueado;

        if (puedoMoverme)
        {
            transform.position = new Vector3(
            cavernicola.transform.position.x, //la pos x de la camara   
            cavernicola.transform.position.y, // la pos y  
             -1); //la pos z
        }
    }
}
