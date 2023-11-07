using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorGUI : MonoBehaviour
{
    public Personaje heroe;
    public Text etiquetaHeroe;
    public Image barraHPHeroe;
    public Text etiquetaEnemigo;
    public Image barraHPEnemigo;
    public Text scoreHeroe;
    public Text vidasHeroe;
    public Text textoVidas;
    public Personaje enemigo;
    public GameObject GameOver;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
        //muestro en texto el hp
        etiquetaHeroe.text = heroe.hp + "/" + heroe.hpMax;

        float porcentajeHPHeroe = heroe.hp / (float)heroe.hpMax;
        barraHPHeroe.fillAmount = porcentajeHPHeroe;

        scoreHeroe.text = heroe.score + "";

        vidasHeroe.text = Personaje.vidas + "";

        textoVidas.text = "Vidas";

        etiquetaEnemigo.text = enemigo.hp + "/" + enemigo.hpMax;
        float porcentajeHPEnemigo = enemigo.hp / (float)enemigo.hpMax;
        barraHPEnemigo.fillAmount = porcentajeHPEnemigo;


        if (heroe.gameOver())
        {
            GameOver.SetActive(true);
        }
    }

}
