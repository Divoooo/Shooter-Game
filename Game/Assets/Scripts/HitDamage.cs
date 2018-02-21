using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Stats))]
public class HitDamage : MonoBehaviour ,IHitable {


    Stats stats;
    

    bool isDied = false;

    public Action hasDied;
    public Action hasTakenDamage;

    IKillable iKillable;
    
    void Start()
    {
        
        stats = GetComponent<Stats>();
        iKillable = (IKillable)GetComponent(typeof(IKillable));    
        if(iKillable == null)
        {
            throw new MissingComponentException("Missing IKillable component! ");
        }
    }


    public void Hit()
    {
        stats.Health -= 10;
        if (hasTakenDamage != null)
        {
            hasTakenDamage();
        }
        if(stats.Health <= 0 && !isDied)
        {
            iKillable.Kill();

            if(hasDied != null)
            {
                hasDied();

            }
            isDied = true;
        }
    }

    
}