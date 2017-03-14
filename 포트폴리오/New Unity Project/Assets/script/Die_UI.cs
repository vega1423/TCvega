using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die_UI : MonoBehaviour {
    float a = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        a += Time.deltaTime;
        if (a >= 1.0f)
        {
            Application.LoadLevel("zzzzzz");
        }
    }
}
