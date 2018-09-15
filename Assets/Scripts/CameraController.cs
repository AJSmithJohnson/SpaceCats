using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public float easeMultiplier = 10;
    public Transform target;

	void Start () {
		
	}
	
	void FixedUpdate () {
        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * easeMultiplier);
            transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, Time.deltaTime * easeMultiplier);
        }
	}
}
