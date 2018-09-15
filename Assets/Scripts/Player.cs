using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float health = 100;

    public float invulnerableTime = 30;
    private float iTimeRemaining = 0;

    public bool canTakeDamage {
        get
        {
            return iTimeRemaining <= 0;
        }
    }
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
        if(!canTakeDamage)
        {
            iTimeRemaining -= Time.deltaTime;
        }
	}
    public void TakeDamage(float amt)
    {
        if (canTakeDamage)
        {
            health -= amt;
            iTimeRemaining = invulnerableTime;
        }
    }
}
