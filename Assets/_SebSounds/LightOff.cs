using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOff : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource playSound;
    public Light lightTarget;
    bool lightBlown = false;

    void OnTriggerEnter(Collider other)
    {
        if (lightBlown == false)
        {
            playSound.Play();

            lightBlown = true;
            lightTarget.enabled = false;
        }

    }

}
    
