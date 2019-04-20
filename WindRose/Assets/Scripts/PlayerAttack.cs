using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public PlayerPickups stick;
    private GameObject Beetle;
    public float attackTimer;
    public float coolDown;
    private int damage;
  
    void Start()
    {
        attackTimer = 0;
        coolDown = 2.0f;
    }

  
    void Update()
    {
        if (stick.stickPickedUp == true)
        {
            damage = 25;
        }
        else if (stick.stickPickedUp == false)
        {
            damage = 10;
        }

        if (GameObject.FindGameObjectWithTag("Beetle"))
        {
            Beetle = GameObject.FindGameObjectWithTag("Beetle");
        }

        if (attackTimer > 0)
        {
            attackTimer -= Time.deltaTime;
        }


        if (attackTimer < 0)
        {
            attackTimer = 0;
        }
       
        if(Input.GetKey(KeyCode.Mouse0))
        {
            if (attackTimer == 0)
            {
                Attack();
                attackTimer = coolDown;
            }
        }

    }

    private void Attack()
    {
        float distance = Vector3.Distance(Beetle.transform.position, transform.position);
        Vector3 dir = (Beetle.transform.position - transform.position).normalized;
        float direction = Vector3.Dot(dir, transform.forward);


        if (distance < 6f)
        {
            if (direction > 0)
            {
                EnemyHealth eh = (EnemyHealth)Beetle.GetComponent("EnemyHealth");
                eh.AddjustCurrentHealth(-damage);

              
            }
        }
    }
}
