using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float floatHeight; //desired float hight



    void FixedUpdate()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right);
        
        Vector2 forward = transform.TransformDirection(Vector2.right) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);

          if (hit.collider != null)
       {
            Debug.Log(hit.collider.name);
            float distance = Mathf.Abs(hit.point.y - transform.position.y);
            float heightError = floatHeight - distance;
       }

    }
}
