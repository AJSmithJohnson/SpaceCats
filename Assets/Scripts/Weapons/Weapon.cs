using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
    /// <summary>
    /// The projectile to spawn when this Weapon shoots.
    /// </summary>
    public Projectile prefabProjectile;
    /// <summary>
    /// The amount of recoil force this Weapon applies to the character shooting.
    /// </summary>
    public float forceKickback = 100;
    /// <summary>
    /// The maximum ammo this Weapon can hold.
    /// </summary>
    public float ammoMax = 10;
    /// <summary>
    /// The cooldown time between shots, in seconds.
    /// </summary>
    public float bulletDelay = .1f;
    /// <summary>
    /// The current amount of ammo this weapon has.
    /// </summary>
    float ammo;
    /// <summary>
    /// The current amount of time (in seconds) to wait before this weapon can be shot again.
    /// </summary>
    float bulletDelayCurrent = 0;
    
    void Start()
    {
        ammo = ammoMax;
    }
    /// <summary>
    /// Counts down the shooting cooldown.
    /// </summary>
    void Update()
    {
        if(bulletDelayCurrent > 0)
        {
            bulletDelayCurrent -= Time.deltaTime;
        }
    }
    /// <summary>
    /// Attempts to shoot the weapon. Only shoots if there is enough ammo
    /// and if the shooting cooldown has counted down.
    /// </summary>
    /// <param name="dir">The direction to shoot the gun.</param>
    /// <returns>The amount of force to apply to the character shooting the weapon.</returns>
    public float Shoot(Vector3 dir)
    {
        if (ammo <= 0) return 0;
        if (bulletDelayCurrent > 0) return 0;

        bulletDelayCurrent = bulletDelay;
        ammo--;

        Projectile p = Instantiate(prefabProjectile, transform.position, Quaternion.identity);
        p.Init(dir);
        
        return forceKickback;
    }
}
