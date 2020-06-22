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

    // void FixedUpdate()
    // {
    //     RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right);
        
    //     Vector2 forward = transform.TransformDirection(Vector2.right) * 10;
    //     Debug.DrawRay(transform.position, forward, Color.green);

    //       if (hit.collider != null)
    //    {
    //         Debug.Log(hit.collider.name);
    //    }

    // }
    
    
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
