using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntFollowHoneyDewScript : MonoBehaviour
{
    private Transform HoneyDew;
    public float speed = 5.0f;


    void Update()
    {

            HoneyDew = GameObject.FindGameObjectWithTag("HoneyDew").transform;

        Vector3 turning = Vector3.RotateTowards(transform.forward, HoneyDew.transform.position, speed * Time.deltaTime, 0.0f);
        transform.position = Vector3.MoveTowards(transform.position, HoneyDew.transform.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.LookRotation(turning);
    }

 
}

