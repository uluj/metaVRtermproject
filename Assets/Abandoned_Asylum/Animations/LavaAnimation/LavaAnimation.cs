using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LavaAnimation : MonoBehaviour
{
    public string triggeringTag = "Player"; // Tag to detect

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        if (animator != null)
        {
            animator.enabled = false; // Start disabled, will be enabled on trigger
        }
    }

    // Trigger-based interaction (e.g., when entering a zone)
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(triggeringTag))
        {
            if (animator != null)
            {
                animator.enabled = true;
            }
        }
    }

    // Collision-based interaction (e.g., hitting the object physically)
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(triggeringTag))
        {
            // Restart the game by reloading the active scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
