﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Camera_move : MonoBehaviour {

    public Camera cam;
    public float sensitivityX = 15.0f;
    public float sensitivityY = 15.0f;

    public float minimumY = -60.0f;
    public float maximumY = 60.0f;

    public float rotationX = 0.0f;
    public float rotationY = 0.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

        rotationX += Input.GetAxis("Mouse X") * sensitivityX;

        cam.transform.localEulerAngles = new Vector3(-rotationY, rotationX,0);
	}
}
