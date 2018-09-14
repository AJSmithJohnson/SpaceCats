using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneLock : MonoBehaviour {

    public Plane plane;

    void Start()
    {
        SetAngle(-90);
    }

    /// <summary>
    /// Sets the plane that this object is locked to.
    /// </summary>
    /// <param name="yaw">The yaw angle to orient the plane (in degrees).</param>
    public void SetAngle(float yaw)
    {
        yaw *= Mathf.Deg2Rad;
        Vector3 normal = new Vector3();
        normal.z = Mathf.Sin(yaw);
        normal.x = Mathf.Cos(yaw);
        plane = new Plane(normal, transform.position);
    }

    void Update()
    {
        Debug.DrawLine(transform.position, transform.position + plane.normal);
    }

}
