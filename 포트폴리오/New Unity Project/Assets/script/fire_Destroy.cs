using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire_Destroy : MonoBehaviour {
    float _count = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _count += 0.1f;

        if (_count >= 3.0f)
        {
            _count = 0;
            Destroy(gameObject);
            
        }
    }
}
