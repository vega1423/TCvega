﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_hand : MonoBehaviour {

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
			coll.GetComponent<_Camera_move> ().player_die = true;
            coll.GetComponent<_Camera_move>().zom_hand_rotation = transform.rotation.y;
        }
    }
}
