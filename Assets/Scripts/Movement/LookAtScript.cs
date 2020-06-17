using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtScript : MonoBehaviour
{



    void Update()
    {
        Vector3 diff = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
	    diff.Normalize();
	 
	    float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
	    transform.rotation = Quaternion.Euler(0f, 0f, rot_z - 0);
    }
}



        // Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // RaycastHit hit;
        // if (Physics.Raycast(ray, out hit))
        // {
        //     Vector3 lookPostion = new Vector3(hit.point.x, transform.position.y, hit.point.z);
        //     Vector3 ScreenPointToRay
        //     transform.LookAt(lookPostion);
        // }
        // Debug.DrawRay(ray.origin, ray.direction * 100, Color.cyan);
