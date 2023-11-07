using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tesoro : MonoBehaviour
{
    public int valor = 1;
    public int exp = 100;
    private EfectosSonoros misSonidos;
    public Animator miAnimador;
    // Start is called before the first frame update
    void Start()
    {
        miAnimador = GetComponent<Animator>();
        misSonidos = GetComponent<EfectosSonoros>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {//este metodo se ejecuta cuando este objeto detecta una colision (NO HAY QUE CAMBIAR NADA)
        GameObject otroObjeto = collision.gameObject;
        if (otroObjeto.tag == "Player")
        {
            print(name + " detecte colision con " + otroObjeto);
            Personaje elPerso = otroObjeto.GetComponent<Personaje>();
            elPerso.dinero += valor;
            elPerso.score += exp;

            misSonidos.reproducir("collectcoin");

            miAnimador.SetTrigger("COLLECT");
            Destroy (gameObject, 1);
            valor = 0;
            exp = 0;
        }
    }     
        
    void Update()
    {
        
    }
}
