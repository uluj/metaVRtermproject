using UnityEngine;

public class LightToggleController : MonoBehaviour
{

    public PokeableObjectListener listener;
    public Light directionalLight;

    private bool previousState = false;

   void Update()
   {
        if (listener == null || directionalLight == null) return;

        if (listener.isPressed && !previousState)
        {
            directionalLight.enabled = !directionalLight.enabled;
        }

        previousState = listener.isPressed;
   }





}
