using UnityEngine;

public class Colorchange : MonoBehaviour
{
    [Header("Light Settings")]
    public Light targetLight;

    [Header("Key Bindings")]
    public KeyCode key1 = KeyCode.Alpha1;
    public KeyCode key2 = KeyCode.Alpha2;
    public KeyCode key3 = KeyCode.Alpha3;

    [Header("Color Options")]
    public Color color1 = Color.red;
    public Color color2 = Color.green;
    public Color color3 = Color.blue;
    public Color color4 = Color.white;
    public Color color5 = Color.yellow;
    public Color color6 = Color.cyan;
    public Color color7 = Color.magenta;
    private bool victory1=false;
    private bool victory2=false;
    private bool victory3=false;

    public bool colorR=false;
    public bool colorG=false;
    public bool colorB=false;

    void Update()
    {
        if (targetLight == null) return;

        if (Input.GetKeyDown(key1)||victory1)
        {
            targetLight.color = color1;
        }
        else if (Input.GetKeyDown(key2)||victory2)
        {
            targetLight.color = color2;
        }
        else if (Input.GetKeyDown(key3)||victory3)
        {
            targetLight.color = color3;
        }

        if(colorR&&!colorG&&!colorB)
        {
            targetLight.color = color1;
        }
        else if (colorG&&!colorB&&!colorR)
        {
            targetLight.color = color2;
        }
        else if (colorB&&!colorG&&!colorR)
        {
            targetLight.color = color3;
        }
        else if(colorR&&colorG&&colorB)
        {
            targetLight.color = color4;
        }
        else if(colorR&&colorG&&!colorB)
        {
            targetLight.color = color5;
        }
        else if(colorR&&colorB&&!colorG)
        {
            targetLight.color = color7;
        }
        else if(colorG&&colorB&&!colorR)
        {
            targetLight.color = color6;
        }
    }
}
