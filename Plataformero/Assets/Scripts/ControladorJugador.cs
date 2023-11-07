using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidadCaminar = 5;
    public float fuerzaSalto = 8;
    public bool enPiso = false;
    public int saltosTotal = 0;

    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    private EfectosSonoros misSonidos;
    private Personaje miPersonaje;
    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
        miPersonaje = GetComponent<Personaje>();
    }

    // Update is called once per frame
    void Update()
    {

        bool puedoMoverme = miPersonaje.estaVivo() && !miPersonaje.bloqueado;


        //lo primero que hago en el pudate es detectar el piso
        detectarPiso();
        float velVert = miCuerpo.velocity.y;

        float movHoriz = Input.GetAxis("Horizontal");

        if (movHoriz > 0 && puedoMoverme)
        {//se mueve a la derecha
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velVert, 0);
            miAnimador.SetBool("CAMINANDO", true);
        }
        else if (movHoriz < 0 && puedoMoverme)
        {//izquierda
            transform.rotation = Quaternion.Euler(0, 180, 0);
            miCuerpo.velocity = new Vector3(-velocidadCaminar, velVert, 0);
            miAnimador.SetBool("CAMINANDO", true);
        }
        else
        {//no se mueve
            miCuerpo.velocity = new Vector3(0, velVert, 0);
            miAnimador.SetBool("CAMINANDO", false);
        }

        if (enPiso == true && Input.GetButtonDown("Jump") && puedoMoverme)//permite salto solo si enPiso es true, asigna 2 saltos a saltosTotal y resta uno del contador con cada salto
        {
            saltosTotal = 2;
            
            miCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);

            saltosTotal = saltosTotal - 1;
            misSonidos.reproducir("salto");
        }

        else if (saltosTotal > 0 && Input.GetButtonDown("Jump") && puedoMoverme) // esto permite el segundo salto
        {
            miCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);
            saltosTotal = saltosTotal - 1;
            misSonidos.reproducir("salto");
        }

        if (Input.GetButtonDown("Fire1") && puedoMoverme)
        {
            miAnimador.SetTrigger("GOLPEAR");
        }


        miAnimador.SetFloat("VEL_VERT", velVert);
        
    }//fin de update

    void detectarPiso()
    {
        //                     origen       direccion      distancia
        enPiso = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

    }

}//fin clase
