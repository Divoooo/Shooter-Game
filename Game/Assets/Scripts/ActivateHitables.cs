using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateHitables {

	public static void HitAll(GameObject gameObject)
    {
        var hitables = gameObject.GetComponents(typeof(IHitable));
        // Debug.Log(hit.name);

        if (hitables == null)
        {
            return;
        }

        foreach (IHitable hitable in hitables)
        {
            hitable.Hit();
        }
    }
}
