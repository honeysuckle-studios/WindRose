using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntFollower : MonoBehaviour
{
    private Transform Player;
    public float speed = 5f;
    public float gap = 3f;
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

        if (GameObject.FindGameObjectWithTag("Player"))
        {
            Player = (GameObject.FindGameObjectWithTag("Player").transform);
                if (Vector3.Distance(transform.position, Player.position) >= gap)
                {
                Anim.SetBool("Walking", true);
                transform.position += transform.forward * speed * Time.deltaTime;
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Player.position - transform.position), rotationSpeed * Time.deltaTime);
                return;
                }
                else
                {
                     Anim.SetBool("Walking", false);
                    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Player.position - transform.position), rotationSpeed * Time.deltaTime);
                return;
                }
        }
    }
}