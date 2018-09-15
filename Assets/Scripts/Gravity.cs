using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    static private Vector3 acceleration;
    Rigidbody body;
    
    void Start()
    {
        body = GetComponent<Rigidbody>();
        SetGravity(270);
    }

    void Update()
    {
        body.AddForce(acceleration * Time.deltaTime);
    }
    static void RandomGravityDirection()
    {
        SetGravity(Random.Range(0, 360));
    }
    static private void SetGravity(float angle, float power = 200)
    {
        angle *= Mathf.Deg2Rad;
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        acceleration = direction * power;
    }
}
