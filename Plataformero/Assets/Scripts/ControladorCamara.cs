using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    public Personaje cavernicola;
    public float velocidadC = 3f;
    public Transform target;
   

    // Update is called once per frame
    void Update()
    {

        Vector3 newPos = new Vector3(target.position.x, target.position.y, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, velocidadC * Time.deltaTime);
    }
}
