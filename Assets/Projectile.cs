using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    public float speed = 10;
    private Rigidbody _body;
    private Rigidbody body {
        get
        {
            if (!_body) _body = GetComponent<Rigidbody>();
            return _body;
        }
    }

	public void Init (Vector3 dir) {
        body.velocity = dir * 10;
	}
}
