using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AntFollower : MonoBehaviour
{
    private Transform Player;
    public float speed = 5f;
    public float gap = 3f;
    public float rotationSpeed = 2f;
    private bool walking;
    private Animator Anim;
    private NavMeshAgent _navMesh;


    private void Start()
    {
        Anim = GetComponent<Animator>();
        _navMesh = GetComponent<NavMeshAgent>();

    }

    private void Update()
    {
        SetDestination();
    }


    void SetDestination()
    {

        if (GameObject.FindGameObjectWithTag("Player"))
        {
            Player = (GameObject.FindGameObjectWithTag("Player").transform);
            if (Vector3.Distance(transform.position, Player.position) >= gap)
            {

                if (Player != null)
                {
                    Anim.SetBool("Walking", true);
                    Vector3 targetVector = Player.transform.position;
                    _navMesh.SetDestination(targetVector);
                }
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
