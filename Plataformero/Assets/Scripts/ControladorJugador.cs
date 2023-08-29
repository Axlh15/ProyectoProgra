using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    private Rigidbody2D MiCuerpo;
    private Animator MiAnimador;
    // Start is called before the first frame update
    void Start()
    {
        MiCuerpo = GetComponent<Rigidbody2D>();
        MiAnimador = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float velVert = MiCuerpo.velocity.y;
        MiCuerpo.velocity = new Vector3(3, velVert, 0);
        MiAnimador.SetBool("CAMINANDO", true);
    }
}
