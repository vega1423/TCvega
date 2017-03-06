using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {
    //public AudioClip sound_eat;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider coll)
    {

        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            //AudioSource.PlayClipAtPoint(sound_eat, transform.position);

        }
    }
}
