using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator animator;

    private bool hasPlayed = false;  // Ensure the animation only plays once
    public GameObject passwordopener;

    void Start()
    {
        // Get the Animator component and disable it initially so the default state doesn't play on start.
        animator = GetComponent<Animator>();
        animator.enabled = false;
    }

    void Update()
    {
        // On pressing "K" and if animation hasn't played yet
        if (Input.GetKeyDown(KeyCode.K) && !hasPlayed)
        {
            animator.enabled = true;                  // Enable the Animator
            animator.Play("DoorOpen", 0, 0f);           // Play the animation from the beginning
            hasPlayed = true;
        }
        
    }
}
