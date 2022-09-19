using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOff : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource playSound;
    public Light lightTarget;

    void OnTriggerEnter(Collider other)
    {
        playSound.Play();

        
        lightTarget.enabled = false;
    }
}
    
