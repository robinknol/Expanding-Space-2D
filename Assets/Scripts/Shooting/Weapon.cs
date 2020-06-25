using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public int damage = 1;
    public GameObject collisionEffect;



    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }


    void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);
        Debug.DrawRay(transform.position, firePoint.right, Color.green);

        if (hitInfo)
        {
            Debug.Log(hitInfo.transform.name);

            EnemyHealth enemy = hitInfo.transform.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                Debug.Log("Damage!!!");
                enemy.EnemyTakeDamage(damage);
            }

            Instantiate(collisionEffect, hitInfo.point, Quaternion.identity);
        }
    }
}
