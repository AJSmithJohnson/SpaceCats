using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberTire : Enemy {

    public Vector3 bounceFactor;
	// Use this for initialization
	void Start () {
        target = GameObject.Find("Player");
        playerScript = GameObject.Find("Player").GetComponent<Player>();
        boxCol = GetComponent<BoxCollider>();
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        rb.velocity = Vector3.zero;
        bounceFactor = target.transform.position - this.transform.position;
	}

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
            if (playerScript.canTakeDamage)
            {
                
                playerScript.bounceFactor = bounceFactor * 3;
                playerScript.Bounce();
               
            }
            
        }

    }

  
}
