using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class EnvironmentChange : MonoBehaviour
{
    public AudioMixerSnapshot outdoorSnapshot;
    public AudioMixerSnapshot indoorCaveSnapshot;
    public AudioMixerSnapshot indoorShipSnapshot;

    public float transitionTime = 0.5f;

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "Ship")
            indoorShipSnapshot.TransitionTo(transitionTime);
        else
            indoorCaveSnapshot.TransitionTo(transitionTime);
    }

    void OnTriggerExit(Collider collider)
    {
        outdoorSnapshot.TransitionTo(transitionTime);
    }
}
