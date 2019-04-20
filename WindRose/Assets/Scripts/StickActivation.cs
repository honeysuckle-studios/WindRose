using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickActivation : MonoBehaviour
{
    public PlayerPickups stick;
    public Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
       
    }

    private void Update()
    {
        if (stick.stickPickedUp == true)
        {
            rend.enabled = true;
        }
        else
        {
            rend.enabled = false;
        }
    }
}