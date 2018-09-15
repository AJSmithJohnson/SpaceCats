using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {


    public float health;
    public float damage;
    public float speed;
    public GameObject target;
    public Player playerScript;
    public BoxCollider boxCol;
    public Rigidbody body;
    public float bounceForce;
    public Vector3 chaseTarget;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void ApplyBounce(Vector3 otherOBJ)
    {
        Vector3 dir = this.transform.position - otherOBJ;
        body.AddForce(dir.x, dir.y, 0, ForceMode.Impulse);
    }

    
}
