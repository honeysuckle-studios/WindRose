using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{ 
    private Transform target;
    private int moveSpeed;
    public int rotationSpeed;
    public int maxDistance;
    public float playerLockOn = 15f;
    public float gap = 5f;
    public float chargeTimer;
    public float coolDown = 8.0f;

    private Transform myTransform;

    private void Awake()
    {
        myTransform = transform;
    }

    void Start()
    {
        maxDistance = 1;
    }

    void Update()
    { 
        if (chargeTimer > 0)
        {
            chargeTimer -= Time.deltaTime;
        }

        if(chargeTimer < 0)
        {
            chargeTimer = 0;
        }

        if (chargeTimer < 4)
        {
            Charge();
        }

        if(chargeTimer == 0)
        {
            chargeTimer = coolDown;
        }
     
       
    }

    private void Charge()
    {
        if (GameObject.FindGameObjectWithTag("Player"))
        {
            target = (GameObject.FindGameObjectWithTag("Player").transform);
            if (Vector3.Distance(transform.position, target.position) <= playerLockOn)
            {
                if (Vector3.Distance(transform.position, target.position) >= gap)
                {
                    myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);

                    if (Vector3.Distance(target.position, myTransform.position) > maxDistance)
                    {
                        moveSpeed = 7;
                        myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
                    }
                }
                return;
            }
        }
    }
}
