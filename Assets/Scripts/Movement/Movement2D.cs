using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public float F_speed;
    public float B_speed;
    public float floatHeight;  
    Rigidbody2D rb2D;

    void Star()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }   

    
    
    void FixedUpdate()
    {   
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.right * F_speed * Time.deltaTime);
        }   

        if(Input.GetKey(KeyCode.S)){
            transform.Translate(Vector3.left * B_speed * Time.deltaTime);
        }
    }
}
