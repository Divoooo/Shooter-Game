using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(AudioSource))]
    
public class HitSound : MonoBehaviour , IHitable {

    public AudioClip clip;
    AudioSource audio;
   
    void Start() { 
    audio = GetComponent<AudioSource>();

    }

    public void Hit()
    {
        audio.PlayOneShot(clip);
    }

    
}
