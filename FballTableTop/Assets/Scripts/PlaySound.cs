using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaySound : MonoBehaviour
{

    AudioClip sound;

    
    // Start is called before the first frame update
    void Start()
    {
        sound = this.gameObject.GetComponent<AudioSource>().clip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayClip()

    {

        

        this.gameObject.GetComponent<AudioSource>().PlayOneShot(sound);
       

    }
}
