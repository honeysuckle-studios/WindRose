using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public PlayerPickups Healthup;
    public int maxHealth = 100;
    public int curHealth = 100;
    private Animator Anim;

    public float healthBarLength;
    
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        Anim = GetComponent<Animator>();
        healthBarLength = Screen.width / 2;
    }

    // Update is called once per frame
    void Update()
    {
        Heal();
        AddjustCurrentHealth(0);

        if (curHealth == 0)
        {
            Destroy(gameObject);
        }

       
    }


    public void AddjustCurrentHealth (int adj)
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

        healthBarLength  = (Screen.width / 2) * (curHealth / (float)maxHealth);
    }

    public void Heal()
    {
        if (Healthup.honeydewPickedUp > 0  && Input.GetKey(KeyCode.Q))
        {
            Anim.SetTrigger("Heal");
            AddjustCurrentHealth(+50);
            Healthup.honeydewPickedUp--;
        }
        else if ( Healthup.honeydewPickedUp < 0)
        {
            Healthup.honeydewPickedUp = 0;
        }
    }
}
