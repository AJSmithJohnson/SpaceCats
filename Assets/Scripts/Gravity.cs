using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    static public float gravPower = 400;
    static public float angle = 361;
    bool moving = false;

    Rigidbody body;


    // Use this for initialization
    void Start()
    {
        //get rigidbody component
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            SetGravityAngle(270);
        }

        if (moving)
        {
            Vector2 direction = DegreeToVector2(angle);
            
            body.AddForce(direction * gravPower * Time.deltaTime);
        }
    }

    //set random angle
    public float SetGravityAngle()
    {
        angle = Random.Range(0, 360);
        moving = true;

        return angle;
    }

    //set angle to specific number
    public float SetGravityAngle(float angle)
    {
        Debug.Log(angle);
        moving = true;

        return angle;
    }

    //convert angle to vector2
    public static Vector2 DegreeToVector2(float degree)
    {
        //convert angle to rad
        float rad = degree * Mathf.Deg2Rad;

        return new Vector2(Mathf.Cos(rad), Mathf.Sin(rad));
    }
}
