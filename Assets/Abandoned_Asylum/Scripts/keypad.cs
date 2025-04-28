using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Oculus.Interaction;
using TMPro;

public class Keypad : MonoBehaviour
{
    [Header("Keypad Buttons (VR)")]
    public PokeInteractable keypad1;
    public PokeInteractable keypad2;
    public PokeInteractable keypad3;
    public PokeInteractable keypad4;
    public PokeInteractable keypad5;
    public PokeInteractable keypad6;
    public PokeInteractable keypad7;
    public PokeInteractable keypad8;
    public PokeInteractable keypad9;
    public PokeInteractable keypad0;
    public PokeInteractable keypadEnter;
    public PokeInteractable keypadClear;

    [Header("Text Display")]
    public TMP_Text myText;

    private string generatedPassword;
    public GameObject PasswordObject;
    public GameObject AnimatorObject;

    private void Awake()
    {
        // Subscribe to VR pointer events.
        keypad1.WhenPointerEventRaised += (pe) => { if (pe.Type == PointerEventType.Select) HandleInput("1"); };
        keypad2.WhenPointerEventRaised += (pe) => { if (pe.Type == PointerEventType.Select) HandleInput("2"); };
        keypad3.WhenPointerEventRaised += (pe) => { if (pe.Type == PointerEventType.Select) HandleInput("3"); };
        keypad4.WhenPointerEventRaised += (pe) => { if (pe.Type == PointerEventType.Select) HandleInput("4"); };
        keypad5.WhenPointerEventRaised += (pe) => { if (pe.Type == PointerEventType.Select) HandleInput("5"); };
        keypad6.WhenPointerEventRaised += (pe) => { if (pe.Type == PointerEventType.Select) HandleInput("6"); };
        keypad7.WhenPointerEventRaised += (pe) => { if (pe.Type == PointerEventType.Select) HandleInput("7"); };
        keypad8.WhenPointerEventRaised += (pe) => { if (pe.Type == PointerEventType.Select) HandleInput("8"); };
        keypad9.WhenPointerEventRaised += (pe) => { if (pe.Type == PointerEventType.Select) HandleInput("9"); };
        keypad0.WhenPointerEventRaised += (pe) => { if (pe.Type == PointerEventType.Select) HandleInput("0"); };

        keypadClear.WhenPointerEventRaised += (pe) => { if (pe.Type == PointerEventType.Select) HandleInput("clear"); };
        keypadEnter.WhenPointerEventRaised += (pe) => { if (pe.Type == PointerEventType.Select) HandleInput("enter"); };
    }

    private void Start()
    {
        // Fetch the generated password from PasswordOpener
        generatedPassword = PasswordObject.GetComponent<PasswordGenerator>().passwordText.text;
        Debug.Log("Generated Password: " + generatedPassword);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0)) HandleInput("0");
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) HandleInput("1");
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) HandleInput("2");
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) HandleInput("3");
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4)) HandleInput("4");
        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5)) HandleInput("5");
        if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6)) HandleInput("6");
        if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7)) HandleInput("7");
        if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8)) HandleInput("8");
        if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9)) HandleInput("9");

        if (Input.GetKeyDown(KeyCode.Backspace)) HandleInput("clear");
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)) HandleInput("enter");
    }

    private void HandleInput(string input)
    {
        if (input == "clear")
        {
            myText.text = "";
            Debug.Log("Cleared text.");
        }
        else if (input == "enter")
        {
            Debug.Log("Enter pressed. Current input: " + myText.text);

            if (myText.text == generatedPassword)
            {
                Debug.Log("Password Correct!");
                ifCorrect();
            }
            else
            {
                Debug.Log("Incorrect Password. Resetting.");
                HandleInput("clear");
            }
        }
        else
        {
            myText.text += input;
            Debug.Log("Added digit: " + input + ". New text: " + myText.text);
        }
    }

    private void ifCorrect()
    {
        Animator animator = AnimatorObject.GetComponent<Animator>();
        if (animator != null)
        {
            animator.enabled = true;
            //animator.SetTrigger("OpenDoor"); // Ensure the animation has a trigger
        }
        else
        {
            Debug.LogWarning("Animator component is missing!");
        }
    }
}
