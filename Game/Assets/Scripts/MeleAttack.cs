using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleAttack : MonoBehaviour {


    public Transform AttackPoint;

	public void Attack()
    {
        var hits = Physics.OverlapSphere(AttackPoint.position, 0.5f);
        foreach(var hit in hits)
        {
            ActivateHitables.HitAll(hit.gameObject);
           
                
            
        }
    }
}
