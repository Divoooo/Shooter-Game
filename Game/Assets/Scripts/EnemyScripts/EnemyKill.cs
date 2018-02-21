using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(ItemDrop))]

public class EnemyKill : MonoBehaviour ,IKillable {

    public AudioClip deathClip;
    public AnimationClip deathAnimation;

    AudioSource audio;
    Animation animation;
    ItemDrop itemDrop;

    public bool IsDead { get; private set; }

    void Start()
    {
        audio = GetComponent<AudioSource>();
        animation = GetComponent<Animation>();
        itemDrop = GetComponent<ItemDrop>();

    }

    public void Kill()
    {
        IsDead = true;

        
        Destroy(gameObject, 2);

        audio.PlayOneShot(deathClip);
        animation.CrossFade(deathAnimation.name);

        // Start random Ammo item drop
        itemDrop.Drop();
    }
    

}
