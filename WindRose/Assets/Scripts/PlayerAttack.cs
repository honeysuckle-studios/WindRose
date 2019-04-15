using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private PlayerPickups stick;
    private Transform Beetle;
    public float attackTimer;
    public float coolDown;
    public float enemyLockOn = 15f;
  
    void Start()
    {
        attackTimer = 0;
        coolDown = 2.0f;
    }

  
    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Beetle"))
        {
            Beetle = GameObject.FindGameObjectWithTag("Beetle").transform;
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
        float distance = Vector3.Distance(Beetle.position, transform.position);
        Vector3 dir = (Beetle.position - transform.position).normalized;
        float direction = Vector3.Dot(dir, transform.forward);

        if (distance < 4f)
        {
            if (direction > 0)
            {
                EnemyHealth eh = (EnemyHealth)Beetle.GetComponent("EnemyHealth");
                if (stick.stickPickedUp == false)
                {
                    eh.AddjustCurrentHealth(-10);
                }

                if (stick.stickPickedUp == true)
                {
                    eh.AddjustCurrentHealth(-25);
                }
            }
        }
    }
}
