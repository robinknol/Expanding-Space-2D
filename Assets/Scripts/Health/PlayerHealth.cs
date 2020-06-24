using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public GameObject heart1;
    public GameObject heart2;
    public GameObject heart3;


    void Start()
    {
        currentHealth = maxHealth;
    }

    
    public void TakeDamage(int damage)
    {
        Debug.Log("OUCH! " + damage + " that must have hurt!");
        currentHealth -= damage;
        

        if(currentHealth == 2)
        {
            heart3.SetActive(false);
        }

        if(currentHealth == 1)
        {
            heart2.SetActive(false);
        }

        if(currentHealth == 0)
        {
            heart1.SetActive(false);

            //death screen code~
        }
        
    }
}
