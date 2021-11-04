using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource AudioSrc;
    public AudioClip DeathAudio;
    public AudioClip GamePlayAudio;
    void Start()
    {
        AudioSrc.clip = GamePlayAudio;
    }

    // Update is called once per frame
    void Update()
    {
        if (StateManager.State == StateManager.States.End) 
        {
            if(AudioSrc.clip == GamePlayAudio)
            {
                AudioSrc.clip = DeathAudio;
                AudioSrc.loop = false;
                AudioSrc.Play();
            }
        }
    }
}
