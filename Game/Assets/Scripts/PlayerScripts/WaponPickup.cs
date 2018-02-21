using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaponPickup : MonoBehaviour, IPickupable {



    public void Pickup(GameObject player)
    {
        var playerEquip = player.GetComponent<PlayerEquip>();
        playerEquip.Equip(gameObject);
    }


    public void Drop(GameObject player)
    {
        
    }


}
