using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Personaje : MonoBehaviour
{
    public int hp = 100;
    public int hpMax = 100;
    public int vidas = 3;
    public int score = 0;

    public GameObject corazonMuertePrefab;
    public Animator miAnimator;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animator>();
        //misSonidos = GetComponent<EfectosSonoros>;

    }

    // Update is called once per frame
    void Update()
    {
        


    }


   

    public void hacerDanio(int puntosDanio, GameObject peligro)
    {
        hp = hp - puntosDanio;
        print(name + " recibe daño de " + puntosDanio + " por " + peligro);
    
        if (hp <= 0)
        { 

            Personaje elPersonn = GetComponent<Personaje>();

            GameObject efectoMuerte = Instantiate(corazonMuertePrefab);
            //coloco la particula en la posicion del cavernicola
            efectoMuerte.transform.position = elPersonn.transform.position;

            miAnimator.SetTrigger("Danio");
            //misSonidos.Reproducir("Daniar");



        }
    }

    public void matarInstantaneo(GameObject agua)
    {
        hp = 0;
        print(name + " recibe muerte " + " por " + agua);

        if (hp <= 0)
        {

            Personaje elPersonn = GetComponent<Personaje>();

            GameObject efectoMuerte = Instantiate(corazonMuertePrefab);
            //coloco la particula en la posicion del cavernicola
            efectoMuerte.transform.position = elPersonn.transform.position;



        }
    }




    

    
}
