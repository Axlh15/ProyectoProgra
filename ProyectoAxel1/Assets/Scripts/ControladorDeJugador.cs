using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDeJugador : MonoBehaviour
{
    //parametro que indica la fuerza con la que salta la pelota
    public float fuerzaSalto = 5;
    //referencia al componente rigidbody 2d 
    private Rigidbody2D Pelotacuerpo;

    // Start is called before the first frame update
    void Start()
    {
        Pelotacuerpo = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //si en este frame fue presionado el boton para saltar (espacio)
        if (Input.GetButtonDown("Jump"))
        {
            print("Se presionò salto");
            //Aplico una fuerza por impulso en el eje Y
            Pelotacuerpo.AddForce(
                new Vector3(
                    0,
                    fuerzaSalto,
                    0),
                ForceMode2D.Impulse);
        }
    }
}
