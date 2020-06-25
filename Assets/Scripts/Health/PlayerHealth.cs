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
    public GameObject ButtonBackToMenu;


    void Start()
    {
        currentHealth = maxHealth;
        ButtonBackToMenu.SetActive(false);
    }

    
    public void TakeDamage(int enemydamage)
    {
        Debug.Log("OUCH! " + enemydamage + " that must have hurt!");
        currentHealth -= enemydamage;
        

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

            Destroy(gameObject);
            
            ButtonBackToMenu.SetActive(true);
        }
        
    }
}
