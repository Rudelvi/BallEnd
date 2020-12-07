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

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(460 , defaultCredictPosition,0);
        titulo.transform.position = new Vector3(460 , defaultTittlePosition,0);
        instrucciones.transform.position = new Vector3(460 , defaultIntruccionesPosition,0);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(defaultCredictPosition<500){
            transform.position = new Vector3(460 , defaultCredictPosition,0);
            defaultCredictPosition = defaultCredictPosition+0.5f;
            
        }

        if(defaultCredictPosition>=130 && defaultTittlePosition<280){
            titulo.transform.position = new Vector3(460 , defaultTittlePosition,0);
            defaultTittlePosition = defaultTittlePosition+0.5f;
            
        }

        if(defaultTittlePosition>=130 && defaultIntruccionesPosition<165){
            instrucciones.transform.position = new Vector3(460 , defaultIntruccionesPosition,0);
            defaultIntruccionesPosition = defaultIntruccionesPosition+0.5f;
            
        }
        
    }
}
