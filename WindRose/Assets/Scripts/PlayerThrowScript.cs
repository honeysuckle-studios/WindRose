using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerThrowScript : MonoBehaviour
{

    public UnityEvent OnFire;

    void Start()
    {
        
    }

    public void Update()
    {
        if( Input.GetButtonDown ("E"))
        {
            if (OnFire != null)
            {
                OnFire.Invoke();
            }
        }
    }

}
