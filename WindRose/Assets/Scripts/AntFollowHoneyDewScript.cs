using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntFollowHoneyDewScript : MonoBehaviour
{
    private Transform HoneyDew;
    public float speed = 5.0f;
    Vector3 LastKnownPosition;
    Quaternion LookAtRotation;

    void Update()
    {

            HoneyDew = GameObject.FindGameObjectWithTag("HoneyDew").transform;
            if (LastKnownPosition != HoneyDew.transform.position)
            {
                LastKnownPosition = HoneyDew.transform.position;
                LookAtRotation = Quaternion.LookRotation(LastKnownPosition - transform.position);
            }
            if (transform.rotation != LookAtRotation)
            {
                transform.rotation = Quaternion.RotateTowards(transform.rotation, LookAtRotation, speed * Time.deltaTime);
            }

            transform.position = Vector3.MoveTowards(transform.position, HoneyDew.transform.position, speed * Time.deltaTime);
    }

 
}

