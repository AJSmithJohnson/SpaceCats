using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatGet : MonoBehaviour {

    public Cats cats;
    public AudioSource source;
    public AudioClip clip1;
    public AudioClip clip2;

	// Use this for initialization
	void Start () {

     //   source = GetComponent<AudioSource>();
     //   source.clip = clip1;
     //   source.Play();
     //   source.loop = true;
	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
          //  source.Stop();
            cats.GetCat();
       //     source.PlayOneShot(clip2);
            Destroy(gameObject);            
        }
    }
}
