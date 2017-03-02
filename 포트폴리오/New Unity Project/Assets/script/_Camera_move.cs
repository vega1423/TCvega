using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Camera_move : MonoBehaviour {

    public Camera cam;



	public float _speed;

    public float sensitivityX = 15.0f;
    public float sensitivityY = 15.0f;

    public float minimumY = -60.0f;
    public float maximumY = 60.0f;

    public float rotationX = 0.0f;
    public float rotationY = 0.0f;

    // Use this for initialization
    void Start () {
		//Cursor.lockState = CursorLockMode.Locked;
		//Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		
			//Cursor.lockState = CursorLockMode.Locked;
			//Cursor.visible = false;

		transform.eulerAngles = new Vector3(0, rotationX,0);

		_camera_view ();
		Move ();
	}


	void _camera_view()
	{
		
		
		rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
		rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

		rotationX += Input.GetAxis("Mouse X") * sensitivityX;

		if (rotationX <= 0.0f) {
			rotationX = 360.0f;
		}
		if (rotationX > 360.0f) {
			rotationX = 0.0f;
		}
		cam.transform.eulerAngles = new Vector3(-rotationY, rotationX,0);
	}

	void Move()
	{
		if (Input.GetKey(KeyCode.W))
		{
			//float w = Input.GetAxis("Vertical");
			transform.Translate(Vector3.forward * _speed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.S))
		{
			//float s = Input.GetAxis("Vertical");
			transform.Translate(Vector3.back * _speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A))
		{
			//float a = Input.GetAxis("Horizontal");
			transform.Translate(Vector3.left * _speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D))
		{
			//float d = Input.GetAxis("Horizontal");
			transform.Translate(Vector3.right * _speed * Time.deltaTime);
		}
        
	}

}
