using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEvent : MonoBehaviour
{
    
    public AudioClip ballSound;

    public string material;

    void PlayBallSound()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.spatialBlend = 1.0f;

        audioSource.Play();
        
    }


}
