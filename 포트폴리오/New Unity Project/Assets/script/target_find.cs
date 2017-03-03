using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//게임 클리어
public class target_find : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!transform.Find("target"))
        {
            Debug.Log("클리어");
            Destroy(gameObject);
            
        }
	}
}
