using UnityEngine;

public class RobotMovementController : MonoBehaviour
{


    [Header("Robot Object")]
    public Transform robotParent;

    [Header("Controls")]
    public PokeableObjectListener moveRightButton;
    public PokeableObjectListener moveLeftButton;
    public PokeableObjectListener rotateButton;

    [Header("Movement Settings")]
    public float moveSpeed = 1f;
    public float rotationSpeed = 90f;

    // Update is called once per frame
    void Update()
    {


        if (robotParent == null) return;

        if (moveRightButton != null && moveRightButton.isPressed)
        {
            robotParent.Translate(Vector3.right * moveSpeed * Time.deltaTime);

        }

        if (moveLeftButton != null && moveLeftButton.isPressed)
        {
            robotParent.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        }

        if (rotateButton != null && rotateButton.isPressed)
        {
            robotParent.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        }


    }
}
