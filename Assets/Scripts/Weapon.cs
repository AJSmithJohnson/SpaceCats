using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public Projectile prefabProjectile;

    public float forceKickback = 100;
    public float ammoMax = 10;
    float ammo;
    
    void Start()
    {
        ammo = ammoMax;
    }

    public float Shoot(Vector3 dir)
    {
        if (ammo <= 0) return 0;
        // TODO: check cooldown

        Projectile p = Instantiate(prefabProjectile, transform.position, Quaternion.identity);
        p.Init(dir);

        return forceKickback;
    }
}
