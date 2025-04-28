using UnityEngine;

public class Teleport : MonoBehaviour
{
    [Header("Teleport Targets")]
    public Transform teleportTarget1;
    public Transform teleportTarget2;

    [Header("Teleport Keys")]
    public KeyCode teleportKey1 = KeyCode.T; // First teleport key
    public KeyCode teleportKey2 = KeyCode.Y; // Second teleport key

    void Update()
    {
        if (Input.GetKeyDown(teleportKey1) && teleportTarget1 != null)
        {
            TeleportTo(teleportTarget1);
        }
        else if (Input.GetKeyDown(teleportKey2) && teleportTarget2 != null)
        {
            TeleportTo(teleportTarget2);
        }
    }

    void TeleportTo(Transform target)
    {
        transform.position = target.position;
        transform.rotation = target.rotation;
    }
}
