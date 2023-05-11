using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour
{
    public AudioClip[] footstepsOnSand;
    public AudioClip[] footstepsOnCave;
    public AudioClip[] footstepsOnWood;
    public AudioClip[] footstepsOnMarble;
    public AudioClip[] footstepsOnMushroom;

    public string material;

    void PlayFootstepSound()
    {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume = Random.Range(0.9f,1.0f);
        audioSource.pitch = Random.Range(0.9f,1.1f);

        switch(material)
        {
            case "Sand":
                if (footstepsOnSand.Length > 0)
                    audioSource.PlayOneShot(footstepsOnSand[Random.Range(0, footstepsOnSand.Length)]);
                break;

            case "Cave":
                if (footstepsOnCave.Length > 0)
                    audioSource.PlayOneShot(footstepsOnCave[Random.Range(0, footstepsOnCave.Length)]);
                break;

            case "Untagged":
                if (footstepsOnMarble.Length > 0)
                    audioSource.PlayOneShot(footstepsOnMarble[Random.Range(0, footstepsOnMarble.Length)]);
                break;

            case "Mushroom":
                if (footstepsOnMushroom.Length > 0)
                    audioSource.PlayOneShot(footstepsOnMushroom[Random.Range(0, footstepsOnMushroom.Length)]);
                break;

            case "Wood":
                if (footstepsOnWood.Length > 0)
                    audioSource.PlayOneShot(footstepsOnWood[Random.Range(0, footstepsOnWood.Length)]);
                break;

            default:
                break;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Untagged":
            case "Cave":
                material = collision.gameObject.tag;
                break;
            case "Sand":
                material = collision.gameObject.tag;
                break;
            case "Mushroom":
                material = collision.gameObject.tag;
                break;
            default:
                break;
        }
    }
}
