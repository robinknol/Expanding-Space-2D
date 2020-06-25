using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int maxEnemyHealth;
    public int currentEnemyHealth;
    public Slider enemySlider;



    void Start()
    {
        currentEnemyHealth = 100;
    }

    
    public void EnemyTakeDamage(int damage)
    {
        currentEnemyHealth -= damage;
        Debug.Log("Took damage " + currentEnemyHealth);

        enemySlider.value = currentEnemyHealth; //calls the EnemyHealthBar component to change value

        if(currentEnemyHealth <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        Destroy(gameObject);
        
        SceneManager.LoadScene(2);
    }
}

