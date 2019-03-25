using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntFollowHoneyDewScript : MonoBehaviour
{
    private Transform HoneyDew;
    public float speed = 5f;
    public float gap = 1.5f;
    public float smellRange = 15f;


    void Update()
    {

        if(GameObject.FindGameObjectWithTag("HoneyDew"))
        {
            HoneyDew = (GameObject.FindGameObjectWithTag("HoneyDew").transform);
            if (Vector3.Distance(transform.position, HoneyDew.position) <= smellRange)
            {
                if (Vector3.Distance(transform.position, HoneyDew.position) >= gap)
                {

                    Vector3 turning = Vector3.RotateTowards(transform.forward, HoneyDew.transform.position, speed * Time.deltaTime, 0.0f);
                    transform.position = Vector3.MoveTowards(transform.position, HoneyDew.transform.position, speed * Time.deltaTime);
                    transform.rotation = Quaternion.LookRotation(turning);
                }
                else
                {

                    Vector3 turning = Vector3.RotateTowards(transform.forward, HoneyDew.transform.position, speed * Time.deltaTime, 0.0f);
                    transform.rotation = Quaternion.LookRotation(turning);
                }
            }
            else
            {
                return;
            }
            return;
        }

        if(GameObject.FindGameObjectWithTag("HoneydewHand"))
        {
            HoneyDew = (GameObject.FindGameObjectWithTag("HoneydewHand").transform);
            if (Vector3.Distance(transform.position, HoneyDew.position) <= smellRange)
            {
                if (Vector3.Distance(transform.position, HoneyDew.position) >= gap)
                {

                    Vector3 turning = Vector3.RotateTowards(transform.forward, HoneyDew.transform.position, speed * Time.deltaTime, 0.0f);
                    transform.position = Vector3.MoveTowards(transform.position, HoneyDew.transform.position, speed * Time.deltaTime);
                    transform.rotation = Quaternion.LookRotation(turning);
                }
                else
                {

                    Vector3 turning = Vector3.RotateTowards(transform.forward, HoneyDew.transform.position, speed * Time.deltaTime, 0.0f);
                    transform.rotation = Quaternion.LookRotation(turning);
                }
            }
            else
            {
                return;
            }
            return;
        }






    }

 
}

