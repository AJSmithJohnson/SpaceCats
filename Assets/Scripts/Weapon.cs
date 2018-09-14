using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public float forceKickback = 100;
    public Projectile prefabProjectile;

    public float Shoot(Vector3 dir)
    {
        // TODO: check ammo
        // TODO: check cooldown

        Projectile p = Instantiate(prefabProjectile, transform.position, Quaternion.identity);
        p.Init(dir);

        return forceKickback;
    }
}
