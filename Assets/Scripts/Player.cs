using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    public float health = 100;
    public float iFrames = 250;
    public bool canTakeDamage = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
        if(!canTakeDamage)
        {
            iFrames -= 1;
            if(iFrames <= 0)
            {
                canTakeDamage = true;
                iFrames = 250;
            }
        }

        
        print(iFrames);
	}
}
