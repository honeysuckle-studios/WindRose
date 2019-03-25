using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyDewScript : MonoBehaviour
{

    private Rigidbody H_Rigidbody;
    [SerializeField] float Power;
    

    private void OnEnable()
    { 
            H_Rigidbody = GetComponent<Rigidbody>();
            H_Rigidbody.AddForce(transform.forward * Power);
      
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}
