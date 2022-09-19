using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickering : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip lightSound;
    public float timer;
    public float randomTime;
   

    public float minimumTime = 0.5f;
    public float maximumTime = 5.0f;

    
    // Start is called before the first frame update
    void Start()
    {
        randomTime = Random.Range(minimumTime, maximumTime);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;     // update real time for timer


        if(timer > randomTime)
        {
            audioSource.PlayOneShot(lightSound);                // play sound
            randomTime = Random.Range(minimumTime, maximumTime);            // works out random time
           
            timer = 0;              // reset timer
        }
    }
}
