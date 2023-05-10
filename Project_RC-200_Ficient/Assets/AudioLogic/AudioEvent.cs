using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEvent : MonoBehaviour
{
    //public AudioClip[] footstepsOnGrass;
    //public AudioClip[] footstepsOnWood;
    public AudioClip ballSound;

    public string material;

    //void PlayFootstepSound()
    //{
    //    AudioSource audioSource = GetComponent<AudioSource>();
    //    audioSource.volume = Random.Range(0.9f, 1.0f);
    //    audioSource.pitch = Random.Range(0.9f, 1.1f);

    //    switch (material)
    //    {
    //        case "Grass":
    //            if (footstepsOnGrass.Length > 0)
    //                audioSource.PlayOneShot(footstepsOnGrass[Random.Range(0, footstepsOnGrass.Length)]);
    //            break;

    //        case "Wood":
    //            if (footstepsOnWood.Length > 0)
    //                audioSource.PlayOneShot(footstepsOnWood[Random.Range(0, footstepsOnWood.Length)]);
    //            break;

    //        default:
    //            break;
    //    }
    //}

    void PlayBallSound()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.spatialBlend = 1.0f;

        audioSource.Play();
        //audioSource.PlayOneShot(ballSound);
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    switch (collision.gameObject.tag)
    //    {
    //        case "Grass":
    //        case "Wood":
    //            material = collision.gameObject.tag;
    //            break;

    //        default:
    //            break;
    //    }
    //}
}
