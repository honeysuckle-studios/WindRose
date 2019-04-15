using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickups : MonoBehaviour
{
    public bool stickPickedUp;
    public int honeydewPickedUp = 0;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "StickPickUp")
        {
            stickPickedUp = true;
        }

        if (collision.gameObject.tag == "HoneyDewPickUp")
        {
            honeydewPickedUp++;
            
        }
    }

}
