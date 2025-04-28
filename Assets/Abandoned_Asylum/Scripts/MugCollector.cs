using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MugCollector : MonoBehaviour
{
    public GameObject passwordCanvas;
    // Store which mugs have been triggered
    private HashSet<string> triggeredMugs = new HashSet<string>();

    // This will be called whenever a mug is triggered
    private void OnTriggerEnter(Collider other)
    {
        string tag = other.tag;

        // Check if the object is one of the required mugs
        if (tag == "Mug1" || tag == "Mug2" || tag == "Mug3")
        {
            // If this mug type hasn't been triggered before, add it to the set
            if (!triggeredMugs.Contains(tag))
            {
                triggeredMugs.Add(tag);
                Debug.Log($"Mug {tag} triggered!");

                // Check if all mugs have been triggered
                if (triggeredMugs.Contains("Mug1") && triggeredMugs.Contains("Mug2") && triggeredMugs.Contains("Mug3"))
                {
                    FireAllMugsTriggeredEvent();
                }
            }
        }
    }

    // This method fires when all three mugs have been triggered
    private void FireAllMugsTriggeredEvent()
    {
        Debug.Log("🔥 All mugs triggered! Firing event...");
        passwordCanvas.SetActive(true);
        // Example: Call another method, enable an object, play a sound, etc.
        // Example: Trigger an animation
        
    }
}
