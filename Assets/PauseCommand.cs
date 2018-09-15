using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseCommand : MonoBehaviour {

    bool paused;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale != 0)
            {
                Time.timeScale = 0;
            } else
            if (Time.timeScale == 0) Time.timeScale = 1;
        }
	}

    public void Unpause() {
        Time.timeScale = 1;
    }

}
