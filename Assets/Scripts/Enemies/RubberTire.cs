using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberTire : Enemy {

    
	// Use this for initialization
	void Start () {
        target = GameObject.Find("Player");
        boxCol = GetComponent<BoxCollider>();
        body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        body.velocity = Vector3.zero;
        
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
            playerScript = GameObject.Find("Player").GetComponent<Player>();
            if (playerScript.canTakeDamage)
            {
                chaseTarget = target.transform.position - this.transform.position;
                playerScript.Bounce( chaseTarget*5 );


            }
            
        }

    }

  
}
