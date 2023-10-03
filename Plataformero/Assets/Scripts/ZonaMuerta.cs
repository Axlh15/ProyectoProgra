using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZonaMuerta : MonoBehaviour
{
    public GameObject splashAguaPrefab;
    private void OnTriggerEnter2D(Collider2D collision)
    {//este metodo se ejecuta cuando este objeto detecta una colision (NO HAY QUE CAMBIAR NADA)
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            print(name + " detecte colision con " + otroObjeto);
            //con esta instruccion obtengo el componente personaje del player
            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            //con esto le mando daño al personaje por 20 puntos y le digo que fue este personaje
            elPerso.matarInstantaneo(this.gameObject);

            //Con esto creo una instancia del prefab en la escena
            GameObject efectoSplash = Instantiate(splashAguaPrefab);
            //coloco la particula en la posicion del cavernicola
            efectoSplash.transform.position = elPerso.transform.position;

        }

    }

}
