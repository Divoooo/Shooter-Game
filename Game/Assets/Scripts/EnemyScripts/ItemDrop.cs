using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour {

    // This is called on Enemy GameObject Destroy


    public GameObject item;
    public float dropChance = 50;

	public void Drop()
    {

        var chance = Random.Range(1, 100);
        if(chance < dropChance)
        {
            Instantiate(item, transform.position, Quaternion.identity);
        }
        
    }
}
