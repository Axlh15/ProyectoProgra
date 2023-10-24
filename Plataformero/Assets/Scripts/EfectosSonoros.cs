using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(AudioSource))]
public class EfectosSonoros : MonoBehaviour
{
    public Efecto[] misEfectos;
    private AudioSource reproductor;
    [Serializable]

    public class Efecto
    {
        public string accion;
        public AudioClip sonido;
    }
    // Start is called before the first frame update
    void Start()
    {
        reproductor = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reproducir(string accion)
    {
        foreach(Efecto e in misEfectos)
        {
            if(e.accion == accion)
            {
                reproductor.clip = e.sonido;
                reproductor.Play();
                return;
            }
        }
    }
}
