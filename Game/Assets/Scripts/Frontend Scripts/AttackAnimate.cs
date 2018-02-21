using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimate : MonoBehaviour , IEquipable{


    Animator animator;
    bool isMounted = false;
   public AnimationClip  attackAnimation;
    

    

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
        // animation = animator.GetComponent<Animation>();
        //animation.speed= controler.velocity.magnitude / 4 + 0.5f;
       
    }
    void Update()
    {

        if (!isMounted)
        {
            return;
        }
        if (Input.GetKeyDown("1"))
        {
            Debug.Log("KEY PRESSED !! ");
            animator.Play(attackAnimation.name);
            
        }
    }
    

    public void Equip(GameObject player)
    {
        isMounted = true;
    }

    public void UnEquip()
    {
        isMounted = false;
    }
}
