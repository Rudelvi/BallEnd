using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text creditos;
    public Text titulo;
    public Text instrucciones;
    public float defaultCredictPosition = -81.0f; 
    public float defaultIntruccionesPosition = -81.0f;
    public float defaultTittlePosition = -81.0f;

    public float defaultHorizontalPosition = 460;

    public float defaultTituloVerticalPosition = 280;
    public float defaultInstruccionVerticalPosition = 280;


    // Start is called before the first frame update
    void Start()
    {

        defaultHorizontalPosition = transform.position.x;
        defaultTituloVerticalPosition = titulo.transform.position.y;
        defaultInstruccionVerticalPosition = instrucciones.transform.position.y;

        transform.position = new Vector3(defaultHorizontalPosition , defaultCredictPosition,0);
        titulo.transform.position = new Vector3(defaultHorizontalPosition , defaultTittlePosition,0);
        instrucciones.transform.position = new Vector3(defaultHorizontalPosition , defaultIntruccionesPosition,0);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(defaultCredictPosition<1500){
            transform.position = new Vector3(defaultHorizontalPosition , defaultCredictPosition,0);
            defaultCredictPosition = defaultCredictPosition+0.5f;
            
        }

        if(defaultCredictPosition>=130 && defaultTittlePosition<defaultTituloVerticalPosition){
            titulo.transform.position = new Vector3(defaultHorizontalPosition , defaultTittlePosition,0);
            defaultTittlePosition = defaultTittlePosition+0.5f;
            
        }

        if(defaultTittlePosition>=130 && defaultIntruccionesPosition<defaultInstruccionVerticalPosition){
            instrucciones.transform.position = new Vector3(defaultHorizontalPosition , defaultIntruccionesPosition,0);
            defaultIntruccionesPosition = defaultIntruccionesPosition+0.5f;
            
        }
        
    }
}
