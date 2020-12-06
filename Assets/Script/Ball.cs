using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Ball : MonoBehaviour
{
    public float velocidad= 30.0f;
    public float puntajeAcumulado = 0.0f;
    public bool finJuego = false;
    public bool gano = false;
    public Text textGanador;
    public Text textPerdedor;
    public Text textInstrucciones;
    public Text textPuntaje;
    public Text textTemporizador;
    public Text textPuntajeFinal;
    public float timeRemaining = 10;
    public float defaultBallPosicion=0;

    AudioSource fuenteDeAudio;

    public AudioClip audioInicio, audioPerdedor, audioGanador, audioPuntos;

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

     void Update()
        {
            if (timeRemaining > 0 && finJuego==false)
            {
                timeRemaining -= Time.deltaTime;
                textTemporizador.text = "Tiempo restante: "+System.Math.Round(timeRemaining,0) + "";

            }else if(finJuego!=true)
            {
                textPerdedor.text = "HAS PERDIDO!";
                textInstrucciones.gameObject.SetActive(true);

                fuenteDeAudio = GetComponent<AudioSource>();
                fuenteDeAudio.clip = audioPerdedor;
                fuenteDeAudio.Play();

                finJuego = true ;
                transform.position = new Vector2(0 , defaultBallPosicion);
            }
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
             transform.position = new Vector2(0 , defaultBallPosicion);
            // this.gameObject.SetActive (false);
         
        }else if(micolision.gameObject.tag == "objetivo"){
            
           

            textGanador.text = "HAS GANADO!" ;
            fuenteDeAudio.clip = audioGanador;
            fuenteDeAudio.Play();
           /// this.gameObject.SetActive (false);
           finJuego =  true;
           gano = true;
            textInstrucciones.gameObject.SetActive(true);
            textPuntajeFinal.gameObject.SetActive(true);

            textPuntajeFinal.text = "Puntaje Final: "+puntajeAcumulado+"/100";

            transform.position = new Vector2(0 , defaultBallPosicion);
        }else if( micolision.gameObject.tag == "coleccionableA"){
            fuenteDeAudio = GetComponent<AudioSource>();
            fuenteDeAudio.clip = audioPuntos;
            fuenteDeAudio.Play();

           puntajeAcumulado = puntajeAcumulado + 50;
           textPuntaje.text = puntajeAcumulado + "";
           micolision.gameObject.SetActive(false);

        }else if( micolision.gameObject.tag == "coleccionableB"){

            fuenteDeAudio = GetComponent<AudioSource>();
            fuenteDeAudio.clip = audioPuntos;
            fuenteDeAudio.Play();

           puntajeAcumulado = puntajeAcumulado + 20;
           textPuntaje.text = puntajeAcumulado + "";

            micolision.gameObject.SetActive(false);

        }else if( micolision.gameObject.tag == "coleccionableR"){

            fuenteDeAudio = GetComponent<AudioSource>();
            fuenteDeAudio.clip = audioPuntos;
            fuenteDeAudio.Play();

           puntajeAcumulado = puntajeAcumulado + 10;
           textPuntaje.text = puntajeAcumulado + "";
            micolision.gameObject.SetActive(false);

        }


    }



   
}
