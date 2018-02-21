using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitParticles : MonoBehaviour , IHitable {

    public ParticleSystem particle;


    public void Hit()
    {
        particle.Play();
    }

    
}
