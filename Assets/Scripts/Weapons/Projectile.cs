using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

    /// <summary>
    /// The desired speed of the projectile. When this projectile is
    /// initialized, this value is multiplied by the desired direction.
    /// </summary>
    public float speed = 10;
    /// <summary>
    /// The maximum lifespan of this projectile, in seconds. The projectile
    /// will auto-destroy after this lifespan has passed.
    /// </summary>
    public float lifespan = 2;
    /// <summary>
    /// The current age (in seconds) of this projectile. Compared to lifespan each frame.
    /// </summary>
    private float age = 0;
    /// <summary>
    /// The RigidBody component of this projectile. 
    /// </summary>
    private Rigidbody _body;
    private Rigidbody body {
        get
        {
            if (!_body) _body = GetComponent<Rigidbody>();
            return _body;
        }
    }
    /// <summary>
    /// This should be called after spawning to set
    /// the desired direction of the projectile.
    /// </summary>
    /// <param name="dir">A directional vector. It should be normalized!</param>
	public void Init (Vector3 dir) {
        body.velocity = dir * 10;
        // Maybe we want to get rid of this, rotate the object on spawn,
        // and set initial velocity in Start()
	}
    /// <summary>
    /// Update the age of the projectile, die of old age...
    /// </summary>
    void Update()
    {
        age += Time.deltaTime;
        if(age >= lifespan)
        {
            Destroy(gameObject);
        }
    }
}
