using UnityEngine;

public class Lens : MonoBehaviour
{
    // Public Animator controller
    public Animator animator;

    // Public key to press to enable the animator (can be set in the Inspector)
    public KeyCode enableKey = KeyCode.Space;

    // Public GameObject to reference
    public GameObject targetObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Disable the animator at the start
        if (animator != null)
        {
            animator.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the public key is pressed
        if (Input.GetKeyDown(enableKey) && animator != null)
        {
            animator.enabled = true;
            if (targetObject != null)
        {
            Colorchange colorChange = targetObject.GetComponent<Colorchange>();
            if (colorChange != null)
            {
                // Change the 'colorg' bool to true
                colorChange.colorR = true;
            }
            else
            {
                Debug.LogWarning("ColorChange component not found on the target object.");
            }
        }
        }
    }

    // This method is called when a collider enters a trigger collider
    private void OnTriggerEnter(Collider other)
    {
        // Enable the animator if the collider is triggered
        if (animator != null)
        {
            animator.enabled = true;
        }

        // Check if the targetObject is set and contains a ColorChange component
        if (targetObject != null)
        {
            Colorchange colorChange = targetObject.GetComponent<Colorchange>();
            if (colorChange != null)
            {
                // Change the 'colorg' bool to true
                colorChange.colorR = true;
            }
            else
            {
                Debug.LogWarning("ColorChange component not found on the target object.");
            }
        }
    }
}
