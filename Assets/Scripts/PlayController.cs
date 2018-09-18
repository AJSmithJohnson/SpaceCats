using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayController : MonoBehaviour {

    public static PlayController main;
    public float howOftenToChangeGravity = 10f;
    public float timeLeft
    {
        get; private set;
    }
    public AudioSource source;
    public AudioClip bwang;
    public float volume;

	void Start () {
        main = this;
        source = gameObject.AddComponent<AudioSource>();
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

            source.PlayOneShot(bwang);
        }
	}
}
