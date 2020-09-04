using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSounds : MonoBehaviour 
{

    public AudioClip sound;
    public AudioClip Hoversound;


    private Button button { get { return GetComponent<Button>(); } }

    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();

        source.clip = sound;

        source.playOnAwake = false;

        button.onClick.AddListener(() => playClicksound());

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playClicksound()
    {
        source.clip = sound;
        source.PlayOneShot(sound);
    }

    public void playHoversound()
    {
        source.clip = Hoversound;
        source.PlayOneShot(sound);

    }


}
