using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampa : MonoBehaviour
{
    public GameObject splashSangrePrefab;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {//este metodo se ejecuta cuando este objeto detecta una colision (NO HAY QUE CAMBIAR NADA)
        
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            print(name + " detecte colision con " + otroObjeto);
            //con esta instruccion obtengo el componente personaje del player
            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            //con esto le mando daño al personaje por 20 puntos y le digo que fue este personaje
            elPerso.hacerDanio(20, this.gameObject);

            GameObject efectoSangre = Instantiate(splashSangrePrefab);
            //coloco la particula en la posicion del cavernicola
            efectoSangre.transform.position = elPerso.transform.position;

            

        }
        
        

    }

}
