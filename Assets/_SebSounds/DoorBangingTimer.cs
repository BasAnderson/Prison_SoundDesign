using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBangingTimer : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip[] doorSound;
    public float timer;
    public float randomTime;
    public int soundIndex;

    public float minimumTime = 0.5f;
    public float maximumTime = 5.0f;


    // Start is called before the first frame update
    void Start()
    {
        randomTime = Random.Range(minimumTime, maximumTime);
        soundIndex = Random.Range(0, doorSound.Length);            // select a random bird sound from array
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;     // update real time for timer


        if (timer > randomTime)
        {
            audioSource.PlayOneShot(doorSound[soundIndex]);                // play sound
            randomTime = Random.Range(minimumTime, maximumTime);            // works out random time
            soundIndex = Random.Range(0, doorSound.Length);
            timer = 0;              // reset timer
        }
    }
}
