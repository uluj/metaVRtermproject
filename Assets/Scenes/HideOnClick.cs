using UnityEngine;
using UnityEngine.UI;

public class HideOnClick : MonoBehaviour
{
    private Button myButton;

    void Start()
    {
        myButton = GetComponent<Button>();

        if (myButton != null)
        {
            myButton.onClick.AddListener(HideSelf);
        }
        else
        {
            Debug.LogWarning("No Button component found on this GameObject!");
        }
    }

    public void HideSelf()
    {
        // Hide the button
        gameObject.SetActive(false);
    }
}
