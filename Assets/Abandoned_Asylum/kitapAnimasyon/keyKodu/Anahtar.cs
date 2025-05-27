using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anahtar : MonoBehaviour
{
    
    public Material targetMaterial;         // The material to change
    public string triggeringTag = "Player"; // Tag that triggers the change

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggeringTag) && targetMaterial != null)
        {
            targetMaterial.color = Color.green;
            gameObject.SetActive(false);
        }
    }
}
