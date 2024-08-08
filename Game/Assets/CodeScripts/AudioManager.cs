using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource SFXSource;
    public AudioClip appearSound;
    public AudioClip disappearSound;
    public AudioClip axeSound;
    public AudioClip swordSound;
    public AudioClip hintSound;
    public AudioClip angryLogVoice;

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
