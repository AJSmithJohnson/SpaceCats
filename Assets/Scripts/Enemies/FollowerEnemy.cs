using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerEnemy : Enemy {

    public Vector3 chaseTarget;
    void Start()
    {
        health = 50;
        damage = 20;
        speed = 2;
        target = GameObject.Find("Player");
        playerScript = target.GetComponent<Player>();
        boxCol = GetComponent<BoxCollider>();
        body = GetComponent<Rigidbody>();
       
    }
    // Update is called once per frame
    void Update()
    {
        
        chaseTarget = target.transform.position - this.transform.position;
        //this.transform.position += chaseTarget * .2f;
        body.AddForce(chaseTarget.x, chaseTarget.y, 0);
       
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
            // FIX: Get player script here?
            if (playerScript.canTakeDamage)
            {
                playerScript.TakeDamage(health);
                playerScript.Bounce();
                boxCol.isTrigger = true;
                BounceBack();
            }
        }
        
    }

    void BounceBack()
    {
        // TODO: Move to Enemy class? I think other Enemy types will want this.
        // Make `chaseTarget` a parameter of the function
        body.AddForce(-chaseTarget.x , -chaseTarget.y, 0, ForceMode.Impulse);
        boxCol.isTrigger = false;
       
    }
    
}
