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
        playerScript =GameObject.Find("Player").GetComponent<Player>();
        boxCol = GetComponent<BoxCollider>();
        rb = GetComponent<Rigidbody>();
       
    }
    // Update is called once per frame
    void Update()
    {
        
        chaseTarget = target.transform.position - this.transform.position;
        //this.transform.position += chaseTarget * .2f;
        rb.AddForce(chaseTarget.x, chaseTarget.y, 0);
       
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
            if (playerScript.canTakeDamage)
            {
                playerScript.health -= damage;
                playerScript.bounceFactor = chaseTarget;
                playerScript.canTakeDamage = false;
                boxCol.isTrigger = true;
                BounceBack();
            }
            print(playerScript.canTakeDamage);
        }
        
    }

    void BounceBack()
    {
        
        rb.AddForce(-chaseTarget.x * 1.5f , -chaseTarget.y * 1.5f, 0, ForceMode.Impulse);
        boxCol.isTrigger = false;
       
    }
    
}
