using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {
    public GameObject eat;
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
            eat.SetActive(true);

        }
        else
        {
            eat.SetActive(false);
        }

    }
}
