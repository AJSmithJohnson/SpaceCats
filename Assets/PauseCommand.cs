using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCommand : MonoBehaviour {

    bool paused;
    public GameObject pMenu;
	// Use this for initialization
	void Start () {
        pMenu.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale != 0)
            {
                pMenu.SetActive(true);                
                Time.timeScale = 0;
            }
            else
            if (Time.timeScale == 0)
            {
                Time.timeScale = 1;
                pMenu.SetActive(false);
            }

        }
	}

    public void Unpause() {
        Time.timeScale = 1;
        pMenu.SetActive(false);
    }

}
