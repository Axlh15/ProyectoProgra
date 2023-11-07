using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Personaje : MonoBehaviour
{
    public int hp = 100;
    public int hpMax = 100;
    public static int vidas = 2;
    public int vidasMax = 2;
    public int score = 0;
    public bool bloqueado = false;
    private Personaje miPersonaje;

    public GameObject sangrePrefab;
    private EfectosSonoros misSonidos;
    public GameObject corazonMuertePrefab;
    public Animator miAnimador;

    public int dinero = 0;


    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        //misSonidos = GetComponent<EfectosSonoros>();
        miPersonaje = GetComponent<Personaje>();

    }

    // Update is called once per frame
    void Update()
    {
        


    }

    public bool estaVivo()
    {
        return hp > 0;
    }

    public void desbloquear()
    {
        bloqueado = false;
    }

    public void hacerDanio(int puntosDanio, GameObject peligro)
    {
        if (estaVivo())
        {
            hp = hp - puntosDanio;
            print(name + " recibe daño de " + puntosDanio + " por " + peligro);
            miAnimador.SetTrigger("DAÑAR");
            GameObject efectoSangre = Instantiate(sangrePrefab);
            efectoSangre.transform.position = this.transform.position;
            bloqueado = true;
            //Dentro de 1.2 seg se va a ejecutar el metodo llamado atacar
            Invoke("desbloquear", 1.2f);

            if (hp <= 0)
            {

                Personaje elPersonn = GetComponent<Personaje>();

                GameObject efectoMuerte = Instantiate(corazonMuertePrefab);
                //coloco la particula en la posicion del cavernicola
                efectoMuerte.transform.position = elPersonn.transform.position;

                miAnimador.SetTrigger("MORIR");
                misSonidos.reproducir("muerte");
                vidas = vidas - 1;

                if (miPersonaje.tag == "Player")
                {
                    if (vidas > 0)
                    {
                        Invoke("reiniciarEscena", 3f);
                    }
                }
            }

        }
        else
        {
            bloqueado = true;
        }

    }

    public void matarInstantaneo(GameObject agua)
    {
        hp = 0;
        print(name + " recibe muerte " + " por " + agua);
        miAnimador.SetTrigger("MORIR");
        vidas = vidas - 1;


        if (hp <= 0)
        {

            Personaje elPersonn = GetComponent<Personaje>();

            GameObject efectoMuerte = Instantiate(corazonMuertePrefab);
            //coloco la particula en la posicion del cavernicola
            efectoMuerte.transform.position = elPersonn.transform.position;


            if (miPersonaje.tag == "Player")
            {
                if (vidas > 0)
                {
                    Invoke("reiniciarEscena", 3f);
                }
            }

        }
    }

    public void vidaCero()
    {
        if (hp <= 0)
        {
            Personaje elPersonn = GetComponent<Personaje>();
            GameObject efectoMuerte = Instantiate(corazonMuertePrefab);
            //coloco la particula en la posicion del cavernicola
            efectoMuerte.transform.position = elPersonn.transform.position;
            miAnimador.SetTrigger("MORIR");
            misSonidos.reproducir("muerte");
            vidas = vidas - 1;

            if (miPersonaje.tag == "Player")
            {
                if (vidas > 0)
                {
                    Invoke("reiniciarEscena", 3f);
                }
            }

        }

    }

    private void reiniciarEscena()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public bool gameOver()
    {
        return vidas <= 0;
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {//Este metodo se ejecuta cuando este objeto detecta una colision

        GameObject otroObjeto = collision.gameObject;

        if (otroObjeto.tag == "Hit" && estaVivo())
        {
            Personaje elPerso = this.GetComponent<Personaje>();

            GameObject efectoSangre = Instantiate(sangrePrefab);
            efectoSangre.transform.position = this.transform.position;
            miAnimador.SetTrigger("DAÑAR");
        }



    }

}
