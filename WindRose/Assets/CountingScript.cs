using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountingScript : MonoBehaviour
{
    public PlayerPickups PickedUp;
    public TextMeshProUGUI pickUpText;
    private int PickUps;

        private void Update()
        {
        PickUps = PickedUp.honeydewPickedUp;

        pickUpText.text = PickUps.ToString();
        }
}
