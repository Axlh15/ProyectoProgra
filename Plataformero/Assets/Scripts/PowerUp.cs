using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{

    private EfectosSonoros misSonidos;
    public Animator miAnimador;
    private ControladorJugador elPerso;
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otro = collision.gameObject;

        if (otro.CompareTag("Player"))
        {

            CapsuleCollider2D playerCollider = otro.GetComponent<CapsuleCollider2D>();

            if (playerCollider != null && collision == playerCollider)
            {
                print(name + " detectó colisión con " + otro);
                //misSonidos.reproducir("powerUp");

                elPerso = otro.GetComponent<ControladorJugador>();

                if (elPerso != null)
                {
                    elPerso.velocidadCaminar *= 2;

                    Invoke("restaurarVelocidad", 3);
                    Invoke("destruirObjeto", 3);
                }
            }
        }
    }


    public void restaurarVelocidad()
    {

        if (elPerso != null)
        {
            elPerso.velocidadCaminar /= 2;

        }
    }


    public void destruirObjeto()
    {

        Destroy(gameObject);

    }


    void Update()
    {

    }
}
