using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    static public float angle { get; private set; }
    static public float power { get; private set; }
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
    static public void RandomGravityDirection()
    {
        SetGravity(Random.Range(0, 360));
    }
    static private void SetGravity(float angle, float power = 300)
    {
        Gravity.angle = angle;
        Gravity.power = power;

        angle *= Mathf.Deg2Rad;
        Vector2 direction = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        acceleration = direction * power;
    }
}
