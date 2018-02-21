using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider))]
public class AmmoPickup : MonoBehaviour ,IPickupable {


    public int ammoAmount = 30;


    public void Drop(GameObject player)
    {
        throw new NotImplementedException();
    }

    public void Pickup(GameObject player)
    {
        var stats = player.GetComponent<Stats>();

        stats.ammoCount += ammoAmount;
        Destroy(gameObject);
    }

   
}
