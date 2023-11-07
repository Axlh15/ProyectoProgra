using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma : MonoBehaviour
{
    public int puntosAtaque = 30;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otroObjeto = collision.gameObject;

        if (otroObjeto.tag == "Enemigo")
        {
            print(name + " detecte colision " + collision.gameObject);
            Personaje enemigo = otroObjeto.GetComponent<Personaje>();
            enemigo.hacerDanio(puntosAtaque, this.gameObject);
            enemigo.vidaCero(); 
        }

    }
}
