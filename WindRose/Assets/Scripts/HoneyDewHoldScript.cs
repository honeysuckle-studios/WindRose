using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyDewHoldScript : MonoBehaviour
{
    public Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        
    }
    public void Update()
    {
        if(Input.GetButton("Q") && GameObject.FindGameObjectWithTag("HoneyDew") == false)
        {
            gameObject.tag = "HoneydewHand";
            rend.enabled = true;
        }
        else
        {
            gameObject.tag = "Hidden Honeydew";
            rend.enabled = false;
        }
    }
}
