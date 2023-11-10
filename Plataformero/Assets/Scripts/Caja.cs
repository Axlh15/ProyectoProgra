using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caja : MonoBehaviour
{
    // Start is called before the first frame update

    public Image ekey;
    void Start()
    {
        ekey.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {//este metodo se ejecuta cuando este objeto detecta una colision (NO HAY QUE CAMBIAR NADA)
        GameObject Caja = collision.gameObject;
        if (Caja.tag == "Player")
        {
            print(name + " detecte colision con " + Caja);
            ekey.enabled = true;
            Personaje elPerso = Caja.GetComponent<Personaje>();

            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
