using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowerEnemy : Enemy {

    void Start()
    {
        health = 50;
        damage = 20;
        speed = 2;
        target = GameObject.Find("Cube");
    }
    // Update is called once per frame
    void Update()
    {
        
        Vector3 chaseTarget = target.transform.position - this.transform.position;
        this.transform.position += chaseTarget * .01f;
       
    }
}
