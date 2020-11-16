using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
     public float velocidad = 30.0f;
    float x = 1;

    // Start is called before the first frame update
    void Start()
    {
         GetComponent<Rigidbody2D>().velocity = Vector2.right *  velocidad;
         print(Vector2.right);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D micolision){
        
        if (micolision.gameObject.tag == "paredes")
        {

             x = x * -1;

           // int y = direccionY(transform.position, micolision.transform.position);

            Vector2 direccion = new Vector2(x,0);
            
            GetComponent<Rigidbody2D>().velocity = direccion * velocidad;

         
        }

    }

}
