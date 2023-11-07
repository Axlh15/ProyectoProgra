using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoAgresivo : MonoBehaviour
{

    private Animator miAnimador;
    private Rigidbody2D miCuerpo;
    private EfectosSonoros misSonidos;
    private GameObject heroeJugador;
    private GameObject enemigo;
    public Personaje cavernicola;
    public GameObject sangrePrefab;
    public bool cerca = false;
    public float velocidadCaminar = 2;
    public float rangoAgro = 3;


    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
        heroeJugador = GameObject.FindGameObjectWithTag("Player");
        enemigo = GameObject.FindGameObjectWithTag("Enemigo");
        cavernicola = GetComponent<Personaje>();

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


        else
        {
            cerca = false;
            print(" Enemigo lejos");
        }

        Personaje cavernicola = heroeJugador.GetComponent<Personaje>();

        if (cerca == true && cavernicola.estaVivo())
        {
            miCuerpo.velocity = transform.right * velocidadCaminar;
            miAnimador.SetBool("CAMINANDO", true);
            miAnimador.SetTrigger("GOLPEAR");
        }

        else
        {
            miCuerpo.velocity = Vector3.zero;
            miAnimador.SetBool("CAMINANDO", false);
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
