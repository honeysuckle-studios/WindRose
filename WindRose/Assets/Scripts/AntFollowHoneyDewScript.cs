using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntFollowHoneyDewScript : MonoBehaviour
{
    private Transform HoneyDew;
    public float speed = 5f;
    public float gap = 1.5f;
    public float smellRange = 15f;
    public float rotationSpeed = 2f;


    void Update()
    {

        if(GameObject.FindGameObjectWithTag("HoneyDew"))
        {
            HoneyDew = (GameObject.FindGameObjectWithTag("HoneyDew").transform);
            if (Vector3.Distance(transform.position, HoneyDew.position) <= smellRange)
            {
                if (Vector3.Distance(transform.position, HoneyDew.position) >= gap)
                {
                    transform.position += transform.forward * speed * Time.deltaTime;
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(HoneyDew.position - transform.position), rotationSpeed * Time.deltaTime);
                }
                else
                {
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(HoneyDew.position - transform.position), rotationSpeed * Time.deltaTime);
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
                    transform.position += transform.forward * speed * Time.deltaTime;
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(HoneyDew.position - transform.position), rotationSpeed * Time.deltaTime);
                }
                else
                {

                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(HoneyDew.position - transform.position), rotationSpeed * Time.deltaTime);
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

