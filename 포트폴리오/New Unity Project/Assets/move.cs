﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public float _speed;
    public float Y_ros = 0.0f;
    public Camera _cam;


    // Use this for initialization
    void Start () {
        //Y_Vec = new Vector3(0,_cam.transform.eulerAngles.y, 0);
        //if (GetComponent<Rigidbody>()) GetComponent<Rigidbody>().freezeRotation = true;
        
    }
	
	// Update is called once per frame
	void Update () {

        //Y_ros = _cam.transform.eulerAngles.y;
        Move();
        //Y_Vec = new Vector3(0, _cam.transform.eulerAngles.y, 0);
        //Y_rot = Y_Vec.y;
       
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.W))
        {
            float z = Input.GetAxis("Vertical");
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            float z = Input.GetAxis("Vertical");
            transform.Translate(Vector3.back * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            float z = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            float z = Input.GetAxis("Horizontal");
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
    }
}
