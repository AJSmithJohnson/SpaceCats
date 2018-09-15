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

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    
}
