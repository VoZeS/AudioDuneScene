using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleTransporte : MonoBehaviour
{
    public Transform Target;
    public GameObject ThePlayer;

    public void OnTriggerEnter(Collider other)
    {
        ThePlayer.transform.position = Target.transform.position;
    }
}
