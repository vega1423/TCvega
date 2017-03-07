using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_sound : MonoBehaviour {
	public AudioClip sound_echo;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider coll)
	{
		if (coll.gameObject.tag == "Player") {

			AudioSource.PlayClipAtPoint(sound_echo, coll.transform.position);
		}
	}
}
