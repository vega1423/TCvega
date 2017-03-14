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

	public bool player_die;

    public float zom_hand_rotation;

	public GameObject UI_cam;
	public GameObject Satrt_UI;
    public GameObject Die_UI;
    float a = 0;
    // Use this for initialization
    void Start () {
		player_die = false;
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = new Vector3(0, rotationX,0);

		_camera_view ();
		Move ();
		if (player_die == true) 
		{
            rotationY += 3.0f;
            transform.eulerAngles = new Vector3(0, -zom_hand_rotation, 0);
            a += Time.deltaTime;
			if (a >= 1.0f) {
                Cursor.visible = true;
                Die_UI.SetActive(true);
                UI_cam.SetActive (false);
				Satrt_UI.SetActive (false);
				gameObject.SetActive (false);
			}

		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
            Time.timeScale = 0;
            UI_cam.SetActive (false);
			Satrt_UI.SetActive (true);
			gameObject.SetActive (false);
			Cursor.visible = true; 
		}

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
			
			transform.Translate(Vector3.forward * _speed * Time.deltaTime);
		}

		if (Input.GetKey(KeyCode.S))
		{
			
			transform.Translate(Vector3.back * _speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A))
		{
			
			transform.Translate(Vector3.left * _speed * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D))
		{
			
			transform.Translate(Vector3.right * _speed * Time.deltaTime);
		}
        
	}


    

}
