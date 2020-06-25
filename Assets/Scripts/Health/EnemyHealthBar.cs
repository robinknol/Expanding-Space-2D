using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{
    public Slider enemySlider;

    public void SetHealth(int currentEnemyHealth)
    {
        enemySlider.value = currentEnemyHealth;
    }
}
