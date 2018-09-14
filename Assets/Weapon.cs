using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public float forceKickback = 100;

	public float Shoot(Vector3 dir)
    {
        // TODO: spawn projectile(s)
        return forceKickback;
    }
}
