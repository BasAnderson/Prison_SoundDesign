using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{

    public AudioSource playSound;
    bool isTriggered = false;

    void OnTriggerEnter(Collider other)
    {
        if(isTriggered == false)
        {
            isTriggered = true;
            playSound.Play();
        }
       

    }
}
