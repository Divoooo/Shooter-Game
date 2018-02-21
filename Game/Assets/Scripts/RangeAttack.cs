using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeAttack : MonoBehaviour , IEquipable{

    
    public LayerMask hitMask;
    public AudioClip attackSoundClip;
    public float attackDistance = 500;
    public float attackRate = 1.0f;

    bool isMounted = false;
    float lastAttackTime = 0;

    Stats playerStats;
    AudioSource audio;



    void Start()
    {
        playerStats = GameObject.Find("Player").GetComponent<Stats>();

        if(playerStats == null)
        {
            throw new MissingComponentException("Stats script is missing form RangeAttack script");
        }
        audio = GetComponent<AudioSource>();
    }
    void Update(){

        if (!isMounted)
        {
            return;
        }
        if(playerStats.ammoCount < 1)
        {
            return;
        }

        if(Time.time - lastAttackTime <= attackRate)
        {
            return;
        }


        if (Input.GetMouseButton(0))
        {
            Attack();
        }
    }

    void Attack()
    {
        RaycastHit hit;
        var camera = Camera.main;

        var direction = camera.transform.TransformDirection(Vector3.forward);
        Physics.Raycast(camera.transform.position, direction,out hit, attackDistance, hitMask);
        ActivateHitables.HitAll(hit.collider.gameObject);
        audio.PlayOneShot(attackSoundClip);


        lastAttackTime = Time.time;

        playerStats.ammoCount--;
    }

    
    public void Equip(GameObject player)
    {
        Debug.Log("PickUp in Rande Attack");
        isMounted = true;
    }

    public void UnEquip()
    {
        Debug.Log("Drop in Rande Attack");
        isMounted = false;
    }
}
