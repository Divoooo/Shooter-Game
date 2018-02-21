using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGAme : MonoBehaviour {

	public void onClickRestart()
    {
        SceneManager.LoadScene("Play");
    }
}
