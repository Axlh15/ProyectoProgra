using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAtacante : MonoBehaviour
{
    private Animator miAnimador;
    private Rigidbody2D miCuerpo;
    private EfectosSonoros misSonidos;
    private GameObject heroeJugador;
    public Personaje cavernicola;
    private GameObject enemigo;
    public GameObject sangrePrefab;
    public bool cerca = false;
    public bool ataque = false;
    public float velocidadCaminar = 2;
    public float rangoAgro = 4;
    public float rangoAtaque = 2;


    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
        heroeJugador = GameObject.FindGameObjectWithTag("Player");
        enemigo = GameObject.FindGameObjectWithTag("Enemigo");
    }

    private void Update()
    {

        Vector3 miPos = this.transform.position;
        Vector3 posHeroe = heroeJugador.transform.position;
        float distanciaHeroe = (miPos - posHeroe).magnitude;

        if (distanciaHeroe < rangoAgro)
        {//el heroe esta dentro del area de agro

            print(heroeJugador.name + " cerca de " + name);
            cerca = true;
            float posEnemigo = this.transform.position.x;

            if (heroeJugador.transform.position.x < posEnemigo)
            {
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
            }

            else
            {
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
            }


        }

        if (distanciaHeroe < rangoAtaque)
        {//el heroe esta dentro del area de agro

            print(heroeJugador.name + " cerca de " + name);
            ataque = true;
            float posEnemigo = this.transform.position.x;

            if (heroeJugador.transform.position.x < posEnemigo)
            {
                this.transform.rotation = Quaternion.Euler(0, 180, 0);
            }

            else
            {
                this.transform.rotation = Quaternion.Euler(0, 0, 0);
            }


        }


        else
        {
            cerca = false;
            print(" Enemigo lejos");
        }


        if (cerca == true)
        {
            miCuerpo.velocity = transform.right * velocidadCaminar;
            miAnimador.SetBool("CAMINANDO", true);
        }

        else
        {
            miCuerpo.velocity = Vector3.zero;
            miAnimador.SetBool("CAMINANDO", false);
        }

        if (ataque == true)
        {
            miAnimador.SetTrigger("GOLPEAR");
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        GameObject otroObjeto = collision.gameObject;

        if (otroObjeto.tag == "Player")
        {

            print(name + " se hizo daño por" + collision.gameObject);
            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            elPerso.hacerDanio(20, this.gameObject);

        }
    }
}
