using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatGet : MonoBehaviour {

    public Cats cats;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            cats.GetCat();
            Destroy(gameObject);            
        }
    }
}
