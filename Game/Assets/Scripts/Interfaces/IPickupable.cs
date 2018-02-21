using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPickupable{


    void Pickup(GameObject player);
    void Drop(GameObject player);
}
