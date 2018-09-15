using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveBarrel : Enemy {

    public GameObject explosion;
	// Use this for initialization
	void Start () {
        target = GameObject.Find("Player");
        boxCol = GetComponent<BoxCollider>();
        body = GetComponent<Rigidbody>();
        health = 5;
    }
	
	// Update is called once per frame
	void Update () {
        body.velocity = Vector3.zero;
        
    }

    void OnCollisionEnter(Collision collision)
    {

        

    }


    public override void CheckForDeath()
    {
       
            
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

  
}
