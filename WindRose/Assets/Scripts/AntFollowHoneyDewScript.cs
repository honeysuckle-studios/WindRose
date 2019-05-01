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
    private bool walking;
    private Animator Anim;

    private void Start()
    {
        Anim = GetComponent<Animator>();
    }

    void Update()
    {

        if(GameObject.FindGameObjectWithTag("HoneyDew"))
        {
            HoneyDew = (GameObject.FindGameObjectWithTag("HoneyDew").transform);
            if (Vector3.Distance(transform.position, HoneyDew.position) <= smellRange)
            {               
                if (Vector3.Distance(transform.position, HoneyDew.position) >= gap)
                {
                    Anim.SetBool("Walking", true);
                    transform.position += transform.forward * speed * Time.deltaTime;
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(HoneyDew.position - transform.position), rotationSpeed * Time.deltaTime);
                }
                else
                {
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(HoneyDew.position - transform.position), rotationSpeed * Time.deltaTime);
                    Anim.SetBool("Walking", false);
                }
            }
            else
            {
                Anim.SetBool("Walking", false);
                return;
            }
         
            return;
        }
        else
        {
            Anim.SetBool("Walking", false);
        }

        if(GameObject.FindGameObjectWithTag("HoneydewHand"))
        {
            HoneyDew = (GameObject.FindGameObjectWithTag("HoneydewHand").transform);
            if (Vector3.Distance(transform.position, HoneyDew.position) <= smellRange)
            {
                if (Vector3.Distance(transform.position, HoneyDew.position) >= gap)
                {
                    Anim.SetBool("Walking", true);
                    transform.position += transform.forward * speed * Time.deltaTime;
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(HoneyDew.position - transform.position), rotationSpeed * Time.deltaTime);
                }
                else
                {

                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(HoneyDew.position - transform.position), rotationSpeed * Time.deltaTime);
                    Anim.SetBool("Walking", false);
                }
            }
            else
            {
                Anim.SetBool("Walking", false);
                return;
            }
          
            return;
        }
        else
        {
            Anim.SetBool("Walking", false);
        }






    }

 
}

