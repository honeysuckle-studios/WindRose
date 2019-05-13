using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject target;
    public float attackTimer;
    public float coolDown;

    void Start()
    {
        attackTimer = 0;
        coolDown = 1.0f;
    }


    void Update()
    {
        if (attackTimer > 0)
            attackTimer -= Time.deltaTime;


        if (attackTimer < 0)
            attackTimer = 0;
      
          if (attackTimer == 0)
            {
                Attack();
                attackTimer = coolDown;
          }
    }

    private void Attack()
    {
        float distance = Vector3.Distance(target.transform.position, transform.position);
        Vector3 dir = (target.transform.position - transform.position).normalized;
        float direction = Vector3.Dot(dir, transform.forward);

        if (distance < 4f)
        {
            if (direction > 0)
            {
                PlayerHealth ph = (PlayerHealth)target.GetComponent("PlayerHealth");
                ph.AddjustCurrentHealth(-10);
            }
        }
    }
}
