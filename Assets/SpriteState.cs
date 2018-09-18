using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteState : MonoBehaviour {

    bool left = true;
    Vector2 pPos;
    Vector2 pos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pos = gameObject.transform.position;

        if (pos.y - pPos.y > 0)
        {
            left = true;
        }
        else
        {
            left = false;
        }
        Debug.Log(left);
        Debug.Log("pPos " + pPos);
        Debug.Log("pos " + pos);

        if (left)
        {
            gameObject.transform.eulerAngles = new Vector3(0, 180, 0);
        }
        else
        {
            gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        pPos = gameObject.transform.position;
    }
}
