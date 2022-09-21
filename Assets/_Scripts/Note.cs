
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Note : MonoBehaviour
{
    [SerializeField]
    
    public AudioClip pickupSound;
    public AudioClip putAwaySound;
    
    private bool touchingNote;
    private bool holdingNote = false;

    [SerializeField] private Canvas UI;
    [SerializeField] private Canvas noteImage;

    // Start is called before the first frame update
    void Start()
    {
        noteImage.enabled = false;
        UI.enabled = false;
    }
    void Update()
    {
        if(touchingNote == true)
        {
            if (Input.GetKeyDown("e") && holdingNote == false)
            {
                Debug.Log("test");
                noteImage.enabled = true;
                holdingNote = true;
                UI.enabled = false;
                GetComponent<AudioSource>()?.PlayOneShot(pickupSound);
            }
            else if (Input.GetKeyDown("e") && holdingNote == true)
            {
                noteImage.enabled = false;
                holdingNote = false;
                UI.enabled = true;
                GetComponent<AudioSource>()?.PlayOneShot(putAwaySound);
            }
        }
        
    }

    // Update is called once per frame
    public void ShowNoteImage()
    {
        noteImage.enabled = true;
        GetComponent<AudioSource>()?.PlayOneShot(pickupSound);
    }
    public void HideNoteImage()
    {
        noteImage.enabled = false;
        GetComponent<AudioSource>().PlayOneShot(putAwaySound);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Note")

        {
            touchingNote = true;
            UI.enabled = true;
            
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Note")
        {
            touchingNote = false;
            UI.enabled = false;
        }
    }
}
