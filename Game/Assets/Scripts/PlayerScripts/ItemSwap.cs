using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSwap : MonoBehaviour {


    /*  public Transform StashPoint;

      Transform mountPoint;

      // Use this for initialization
      void Start () {
          mountPoint = GetComponent<PlayerPickup>().mountPick;
      }

      // Update is called once per frame
      void Update () {
          if (Input.GetKeyDown(KeyCode.E))
          {
              print("E is down");
              var item = mountPoint.GetComponentInChildren(typeof(IPickupable));
              if(item == null)
              {
                  print("E nukll");
                  return;
              }
              item.transform.SetParent(StashPoint.transform);
              item.transform.position = StashPoint.transform.position;
            //  item.transform.parent = StashPoint;
          }
      }*/

    Transform stashPoint;
    Transform equipPoint;

    PlayerEquip playerEquip;


    void Start()
    {

        playerEquip = GetComponent<PlayerEquip>();

        stashPoint = playerEquip.stashPoint;
        equipPoint = playerEquip.equipPoint;
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            var moutedItem = GetItem(equipPoint);
            var stashedItem = GetItem(stashPoint);

            if (moutedItem != null)
            {
                playerEquip.UnEquip(moutedItem.gameObject);
            }

            if (stashedItem != null)
            {
                playerEquip.Equip(stashedItem.gameObject);
            }
        }

     }
    private Component GetItem(Transform point)
    {
        return point.GetComponentInChildren(typeof(IPickupable));
    }
    
}
