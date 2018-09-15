using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour {

    public Camera cam;
    private Rigidbody body;
    private Weapon currentWeapon;
    private Weapon weapon1;
    private Weapon weapon2;
    private Weapon weapon3;

	void Start () {
        body = GetComponent<Rigidbody>();
        //weapon = GetComponentInChildren<Weapon>();
        weapon1 = transform.Find("KittenCannon").GetComponent<Weapon>();
        weapon2 = transform.Find("Cannon").GetComponent<Weapon>();
        //weapon2 = transform.FindChild("Laser").GetComponent<Weapon>();
       weapon3 = transform.Find("Laser").GetComponent<Weapon>();

        SetWeapon(1);
    }
	
	void Update () {

        if (Input.GetKeyDown("1")) SetWeapon(1);
        if (Input.GetKeyDown("2")) SetWeapon(2);
        if (Input.GetKeyDown("3")) SetWeapon(3);

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
            float thrust = currentWeapon.Shoot(-thrustDir);
            body.AddForce(thrustDir * thrust, ForceMode.Impulse);
        }

    }

    void SetWeapon(int x)
    {
        Debug.Log("Switching to " + x);
        switch (x)
        {
            case 1:
                currentWeapon = weapon1;
                weapon1.GetComponentInParent<SpriteRenderer>().enabled = true;
                weapon2.GetComponentInParent<SpriteRenderer>().enabled = false;
                weapon3.GetComponentInParent<SpriteRenderer>().enabled = false;
                break;
            case 2:
                currentWeapon = weapon2;
                weapon1.GetComponentInParent<SpriteRenderer>().enabled = false;
                weapon2.GetComponentInParent<SpriteRenderer>().enabled = true;
                weapon3.GetComponentInParent<SpriteRenderer>().enabled = false;
                break;
            case 3:
                currentWeapon = weapon3;
                weapon1.GetComponentInParent<SpriteRenderer>().enabled = false;
                weapon2.GetComponentInParent<SpriteRenderer>().enabled = false;
                weapon3.GetComponentInParent<SpriteRenderer>().enabled = true;
                break;
        }
    }
}
