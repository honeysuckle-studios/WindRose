using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 50;
    public int curHealth = 50;

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

    private void OnGUI()
    {
        GUI.Box(new Rect(10, Screen.height - 80, healthBarLength, 20), curHealth + "/" + maxHealth);
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
