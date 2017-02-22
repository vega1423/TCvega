using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

    public enum RotationAxes { MouseXAndY = 0, MouseX = 1, MouseY = 2 }
    public RotationAxes axes = RotationAxes.MouseXAndY;
    public float sensitivityX = 15.0f;
    public float sensitivityY = 15.0f;
    public float minimumX = -360.0f;
    public float maximumX = 360.0f;
    public float minimumY = -60.0f;
    public float maximumY = 60.0f;
    public float rotationX = 0.0f;
    public float rotationY = 0.0f;
    void Update()
    {
        if (axes == RotationAxes.MouseXAndY)
        {
            rotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

            rotationX += Input.GetAxis("Mouse Y") * sensitivityX;
            rotationX = Mathf.Clamp(rotationX, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);
        }
        else if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
        }
        else
        {
            rotationX += Input.GetAxis("Mouse Y") * sensitivityY;
            rotationX = Mathf.Clamp(rotationX, minimumY, maximumY);

            transform.localEulerAngles = new Vector3(-rotationX, transform.localEulerAngles.y, 0);
        }
    }

    void Start()
    {
        // Make the rigid body not change rotation
        //if (GetComponent<Rigidbody>()) GetComponent<Rigidbody>().freezeRotation = true;
    }

}
