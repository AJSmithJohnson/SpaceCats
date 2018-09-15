using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : Enemy {

    //G
    private float expansionTime = 1;
    // Use this for initialization
    void Start () {
        
        damage = 50;
       
        
        target = GameObject.Find("Player");

        boxCol = GetComponent<BoxCollider>();
        body = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        // 
        chaseTarget = target.transform.position - this.transform.position;
        chaseTarget *= 2.0f;
        if(expansionTime > 0)
        {
            this.transform.localScale += new Vector3(1.0f, 1.0f, 1.0f);
            expansionTime -= Time.deltaTime;

        }
        else
        {
            Destroy(gameObject);
        }

    }



    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
            playerScript = target.GetComponent<Player>();
            if (playerScript.canTakeDamage)
            {
                playerScript.TakeDamage(damage);
                ApplyBounce(target.transform.position);
                playerScript.Bounce(chaseTarget);
            
            }
        }
         if (collision.gameObject.tag == "Enemy")
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();
            if (enemy) enemy.TakeDamage(damage);
           
        }

    }
}
