using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Interaction;

public class PokeableObjectListener : MonoBehaviour
{

    public PokeInteractable pokeableObject;
    [HideInInspector]
    public bool isPressed = false;

    
    private void Awake()
    {
        pokeableObject.WhenPointerEventRaised += HandlePointerEvent;

    }


    private void HandlePointerEvent(PointerEvent pointerEvent)
    {
        if (pointerEvent.Type == PointerEventType.Select)
        {
            isPressed = true;
            Debug.Log("Buton is pressed.");

        }
        else if (pointerEvent.Type == PointerEventType.Unselect)
        {
            isPressed = false;
            Debug.Log("Buton is pressed.");
        }
          

    }

    private void OnDestroy()
    {
        pokeableObject.WhenPointerEventRaised -= HandlePointerEvent;

    }


}
