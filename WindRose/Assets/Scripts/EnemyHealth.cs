using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 800;
    public int curHealth = 800;

    public float healthBarLength;
 
    void Start()
    {
        healthBarLength = Screen.width / 2;
    }


    void Update()
    {
        AddjustCurrentHealth(0);

        if (curHealth == 0)
        {
            Destroy(gameObject);
        }
    }

    public void AddjustCurrentHealth(int adj)
    {
        curHealth += adj;

        if (curHealth < 0)
        {
            curHealth = 0;
        }

        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }

        if (maxHealth < 1)
        {
            maxHealth = 1;
        }

        healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth);
    }
}
