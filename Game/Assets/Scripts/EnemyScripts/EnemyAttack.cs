using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(EnemyKill))]

public class EnemyAttack : MonoBehaviour {

    Transform player;

    
    public AnimationClip enemyAttackClip;
    public AudioClip attackAudio;
    public AudioClip chargingAudio;

    Animation animation;
    AudioSource audio;
    EnemyKill enemyKill;

    public float range = 2f;
    bool isCharging = false;

    void Start()
    {

        animation = GetComponent<Animation>();
        audio = GetComponent<AudioSource>();
        enemyKill = GetComponent<EnemyKill>();

        player = GameObject.Find("Player").transform;
    }

    void Update()
    {

        if (CanAttack)
        {
            Invoke("Attack", 2);
            audio.PlayOneShot(chargingAudio);
            isCharging = true;
        }
    }

    private bool IsInAttackRange
    {
        get { return Vector3.Distance(transform.position, player.position) < range; }
    }
    

   
    private bool CanAttack
    {
        get { return IsInAttackRange && !isCharging && !enemyKill.IsDead; }
    }
   

    private void Attack()
    {
        isCharging = false;

        if (!IsInAttackRange && enemyKill.IsDead)
        {
            return;
        }

        ActivateHitables.HitAll(player.gameObject);
        animation.CrossFade(enemyAttackClip.name);
        audio.PlayOneShot(attackAudio);
        
    }
}
