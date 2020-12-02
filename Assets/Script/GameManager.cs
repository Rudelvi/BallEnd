using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string nivel;
    public string siguienteNivel;
    public Ball ball;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetMouseButton(0)){
            //Cargo la escena de Juego
            // Nombre de la scene del juego, en mi caso es SampleScene
            
            

            if(nivel!="Inicio"){

                if(ball.finJuego){

                    if(ball.gano){
                        SceneManager.LoadScene(siguienteNivel);
                    }else
                    {
                        SceneManager.LoadScene(nivel);
                    }
                    
                }
            }else
            {
                SceneManager.LoadScene(siguienteNivel);
            }
            
        }

        
    }
}
