using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitRoom : MonoBehaviour
{

    public UnityEvent EnterRoom;
    public string Tag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag))
        {
            EnterRoom.Invoke();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
