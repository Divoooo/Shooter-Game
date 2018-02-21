using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEquip : MonoBehaviour {

    public Transform equipPoint;
    public Transform stashPoint;

   
    public void Equip(GameObject item)
    {
        if (equipPoint.childCount > 0)
        {
            return;
        }
      //  item.transform.parent = equipPoint;
        item.transform.SetParent(equipPoint.transform);
        item.transform.position = equipPoint.transform.position;
        //var equipables = GetEquipables(item);


        foreach (IEquipable equipable in GetEquipables(item))
        {
            equipable.Equip(gameObject);
        }
    }

    public void UnEquip(GameObject item)
    {
       // item.transform.parent = stashPoint;
        item.transform.SetParent(stashPoint.transform);
        item.transform.position = stashPoint.transform.position;
        

        //  var equipables = GetEquipables(item);


        foreach (IEquipable equipable in GetEquipables(item))
        {
            equipable.UnEquip();
        }
    }

    private static Component[] GetEquipables(GameObject item)
    {
        return item.GetComponents(typeof(IEquipable));
    }
}
