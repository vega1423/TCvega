using System.Collections;
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
            Time.timeScale = 0;
        }
    }
}
