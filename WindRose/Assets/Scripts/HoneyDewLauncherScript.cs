using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoneyDewLauncherScript : MonoBehaviour
{
    [SerializeField] GameObject Honeydew;
    [SerializeField] Transform Reference;
    [SerializeField] PlayerThrowScript Player;
    
    private void OnEnable()
    {
        Player.OnFire.AddListener(Fire);
    }

  
    private void OnDisable()
    {
        Player.OnFire.RemoveListener(Fire);
    }

   
    private void Fire()
    {
        if (GameObject.FindGameObjectWithTag("HoneyDew") == false)
        {
            Instantiate(Honeydew, Reference.position, Reference.rotation);
        }
        else
        {
            return;
        }
    }
}
