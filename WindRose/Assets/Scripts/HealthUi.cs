using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUi : MonoBehaviour
{
    private int health;
    public PlayerHealth Health;
    public Slider healthBar;
   

    void Update()
    {
        health = Health.curHealth;
        healthBar.value = health;
        
    }

    
}
