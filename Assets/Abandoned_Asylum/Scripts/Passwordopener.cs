using UnityEngine;
using TMPro;

public class PasswordGenerator : MonoBehaviour
{
    [Header("UI Elements")]
    public TMP_Text passwordText; // TextMeshPro text to display the password
    public GameObject canvas; 

    //passwordText.text
    // The UI canvas to toggle

    private void Awake()
    {
        GeneratePassword(); // Generate a password when the game starts
        canvas.SetActive(false); // Ensure canvas is hidden initially
    }

    private void Update()
    {
        // Toggle canvas visibility when P key is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {
            canvas.SetActive(!canvas.activeSelf);
        }
    }

    private void GeneratePassword()
    {
        int randomPassword = Random.Range(1000, 9999); // Generate a 4-digit number
        passwordText.text = randomPassword.ToString(); // Display the password
    }
}
