using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour {

	
	
	// Update is called once per frame
	void Update () {
        if (Screen.lockCursor == false)
        {

            if (Input.GetMouseButtonDown(0))
            {
                Screen.lockCursor = true;
            }
        }
	}
}
