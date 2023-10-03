using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    public int hp = 100;
    public int hpMax = 100;
    public int vidas = 3;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hacerDanio(int puntosDanio, GameObject peligro)
    {
        hp = hp - puntosDanio;
        print(name + " recibe daño de " + puntosDanio + " por " + peligro);
    }

    public void matarInstantaneo(GameObject agua)
    {
        hp = 0;
        print(name + " recibe muerte " + " por " + agua);
    }
}
