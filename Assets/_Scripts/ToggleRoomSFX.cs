using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleRoomSFX : MonoBehaviour
{
    public AudioSource audioSource;
    bool hasEntered = false;

    private void OnTriggerEnter(Collider other)
    {
        if(hasEntered == false)
        {
            hasEntered = true;
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
    }
}
