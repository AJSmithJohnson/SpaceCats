﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour {

    public Camera cam;
    private Rigidbody body;
    private Weapon weapon;

	void Start () {
        body = GetComponent<Rigidbody>();
        weapon = GetComponentInChildren<Weapon>();
	}
	
	void Update () {

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(-transform.forward, transform.position);
        float dis;

        Vector3 thrustDir = Vector3.zero;

        if (plane.Raycast(ray, out dis))
        {
            Vector3 pos = ray.GetPoint(dis);
            Debug.DrawLine(transform.position, pos);
            thrustDir = transform.position - pos;
            
        }

        if (Input.GetButton("Fire1"))
        {
            thrustDir.Normalize();
            float thrust = weapon.Shoot(-thrustDir);
            body.AddForce(thrustDir * thrust, ForceMode.Impulse);
        }
	}
}
