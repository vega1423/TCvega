using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_move : MonoBehaviour {
	public float _zomSpeed = 0.0f;
	public float _speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(_speed >= _zomSpeed)
		{
			_zomSpeed += 0.1f;
			transform.Translate (Vector3.forward*_zomSpeed*Time.deltaTime);
		}


		transform.Translate (Vector3.forward*_zomSpeed*Time.deltaTime);
	}
}