using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraDePelota : MonoBehaviour
{
    //Este es un atributo pùblico
    public Transform Pelota;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Pelota.position.x,//la pos x de la cam
            Pelota.position.y,// la pos y de la cam
            -1);//pos z
    }
}
