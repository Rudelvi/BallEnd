﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
    public float velocidad= 30.0f;
    bool finJuego = false;
    public Text textGanador;
    public Text textPerdedor;
    public Text textInstrucciones;

    AudioSource fuenteDeAudio;

    public AudioClip audioInicio, audioPerdedor, audioGanador;

    // Start is called before the first frame update
    void Start()
    {
        fuenteDeAudio = GetComponent<AudioSource>();

        fuenteDeAudio.clip = audioInicio;
        fuenteDeAudio.Play();
    }

    void FixedUpdate()
    {
         float v = 0;
         float h = 0;

        if (!finJuego){

             v = Input.GetAxisRaw("Vertical");
             h = Input.GetAxisRaw("Horizontal");
        }

        GetComponent<Rigidbody2D>().velocity = new Vector2(h*velocidad , v * velocidad);
        

    }

     void OnCollisionEnter2D(Collision2D micolision){
        
        if (micolision.gameObject.tag == "obstaculo")
        {
            

            textPerdedor.text = "HAS PERDIDO!" ;

            textInstrucciones.gameObject.SetActive(true);
            fuenteDeAudio = GetComponent<AudioSource>();
             fuenteDeAudio.clip = audioPerdedor;
             fuenteDeAudio.Play();
             finJuego = true ;
             transform.position = new Vector2(0 , -32);
            // this.gameObject.SetActive (false);
         
        }else if(micolision.gameObject.tag == "objetivo"){
            
           

            textGanador.text = "HAS GANADO!" ;
            fuenteDeAudio.clip = audioGanador;
            fuenteDeAudio.Play();
           /// this.gameObject.SetActive (false);
           finJuego =  true;
            textInstrucciones.gameObject.SetActive(true);
            
            transform.position = new Vector2(0 , -32);
        }

    }



   
}