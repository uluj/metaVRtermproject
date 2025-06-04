using UnityEngine;

public class EnergyPickup : MonoBehaviour
{
    public float energyAmount = 20f;

    //Yiğit audio kısmı
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        audioManager.PlaySFX(audioManager.energyPickup);
        PlayerEnergy energy = other.GetComponentInParent<PlayerEnergy>();
        if (energy != null)
        {
            energy.AddEnergy(energyAmount);

            Destroy(gameObject); 
        }
    }
}
