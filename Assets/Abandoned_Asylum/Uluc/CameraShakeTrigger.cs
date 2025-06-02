using UnityEngine;

public class CameraShakeTrigger : MonoBehaviour
{
    public float shakeDuration = 0.5f;
    public float shakeMagnitude = 0.3f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CameraShake.Instance.Shake(shakeDuration, shakeMagnitude);
        }
    }
}
