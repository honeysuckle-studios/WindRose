using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerThrowScript : MonoBehaviour
{
    public UnityEvent OnFire;
    private Animator Anim;
 


    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    public void Update()
    {   

        if ( Input.GetButtonDown ("E"))
        {
            Anim.SetTrigger("Throw");
            if (OnFire != null)
            {
                OnFire.Invoke();
            }
        }
    }

}
