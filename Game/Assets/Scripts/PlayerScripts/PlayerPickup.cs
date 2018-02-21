using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour {

   
    void OnTriggerEnter(Collider collider)
    {

        var pickupable = collider.GetComponents(typeof(IPickupable));

        if (pickupable == null)
        {
            return;
        }

        foreach (IPickupable pickup in pickupable)
        {
            pickup.Pickup(gameObject);
        }
    }


}
