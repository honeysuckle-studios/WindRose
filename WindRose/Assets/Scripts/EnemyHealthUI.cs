using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthUI : MonoBehaviour
{
    private int health;
    public EnemyHealth Health;
    public EnemyAI AI;
    public Slider healthBar;

    private void Start()
    {
        healthBar.value = 0;
    }


    void Update()
    {
        if (AI.Attacking == true)
        {
            health = Health.curHealth;
            healthBar.value = health;
        }
       
    }
}
