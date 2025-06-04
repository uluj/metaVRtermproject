using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
  [Header("-------Audio Source-------")]
  [SerializeField] [CanBeNull] AudioSource musicSource;
  [SerializeField] [CanBeNull] AudioSource sfxSource;
  
  [Header("-------Audio Clip-------")]
  public AudioClip energyPickup;
  public AudioClip keyboard;
  public AudioClip correct;
  public AudioClip wrong;
  public AudioClip breake;

  public void PlaySFX(AudioClip clip)
  {
    sfxSource.PlayOneShot(clip);
  }
}
