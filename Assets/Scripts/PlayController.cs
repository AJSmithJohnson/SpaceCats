using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayController : MonoBehaviour {

    public static PlayController main;
    public float howOftenToChangeGravity = 10f;
    public float timeLeft
    {
        get; private set;
    }

	void Start () {
        main = this;
	}
	
	// Update is called once per frame
	void Update () {
		if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
        } else
        {
            Gravity.RandomGravityDirection();
            timeLeft = howOftenToChangeGravity;
        }
	}
}
