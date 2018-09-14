using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHolder : MonoBehaviour {

    public Camera cam;
    private PlaneLock planeLock;
    private Rigidbody body;

	void Start () {
        planeLock = GetComponent<PlaneLock>();
        body = GetComponent<Rigidbody>();
	}
	
	void Update () {

        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Plane plane = new Plane(Vector3.back, transform.position);
        float dis;

        Vector3 dir = Vector3.zero;

        if (planeLock.plane.Raycast(ray, out dis))
        {
            Vector3 pos = ray.GetPoint(dis);
            Debug.DrawLine(transform.position, pos);
            dir = transform.position - pos;
            
        }

        if (Input.GetButton("Fire1"))
        {
            dir.Normalize();
            body.AddForce(dir * Time.deltaTime * 50);
        }
	}
}
