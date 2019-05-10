using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitRoom : MonoBehaviour
{

  //  public UnityEvent EnterRoom;
   // public string Tag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           // EnterRoom.Invoke();
            SceneManager.LoadScene(0);
        }
    }
}
