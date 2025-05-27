using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitapKodu : MonoBehaviour
{
    public GameObject object1; // Will be deactivated
    public GameObject object2; // Will be activated
    public GameObject object3; // Will be activated

    public string triggeringTag = "Player"; // Tag that triggers the logic

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggeringTag))
        {
            if (object1 != null) object1.SetActive(false);
            if (object2 != null) object2.SetActive(true);
            if (object3 != null) object3.SetActive(true);
        }
    }

}
