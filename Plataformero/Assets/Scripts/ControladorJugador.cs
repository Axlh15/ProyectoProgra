using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float velocidadCaminar = 5;
    public float fuerzaSalto = 8;
    public bool enPiso = false;
    public int saltosUsados = 0;
    public int saltosTotal = 0;

    private Rigidbody2D miCuerpo;
    private Animator miAnimador;
    // Start is called before the first frame update
    void Start()
    {
        miCuerpo = GetComponent<Rigidbody2D>();
        miAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //lo primero que hago en el pudate es detectar el piso
        detectarPiso();
        float velVert = miCuerpo.velocity.y;

        float movHoriz = Input.GetAxis("Horizontal");

        if (movHoriz > 0)
        {//se mueve a la derecha
            transform.rotation = Quaternion.Euler(0, 0, 0);
            miCuerpo.velocity = new Vector3(velocidadCaminar, velVert, 0);
            miAnimador.SetBool("CAMINANDO", true);
        }
        else if (movHoriz < 0)
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

        if (enPiso == true && saltosUsados < 2 && Input.GetButtonDown("Jump"))
        {
            saltosUsados++;
            saltosTotal = 2;
            if (saltosTotal > 0) 
            {
                Input.GetButtonDown("Jump"))
            }

            //if (saltosUsados)saltosTotal--;
            
            miCuerpo.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode2D.Impulse);    
        }
        
        miAnimador.SetFloat("VEL_VERT", velVert);
        
    }//fin de update

    void detectarPiso()
    {
        //                     origen       direccion      distancia
        enPiso = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

    }

}//fin clase
