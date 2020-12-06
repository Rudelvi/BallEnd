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
        if (Input.GetMouseButton(0)){

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

        if(Input.GetKeyDown(KeyCode.R)){
            if(ball.finJuego)
            {
                SceneManager.LoadScene(nivel);
            }
            
        }

        if(Input.GetKeyDown(KeyCode.M)){
            SceneManager.LoadScene("Inicio");
        }

        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
            Debug.Log("salio del juego");
        }



        
    }
}
