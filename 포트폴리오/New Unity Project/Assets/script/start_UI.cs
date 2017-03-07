using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_UI : MonoBehaviour {
	public GameObject player;
	public GameObject UI_cam;
	public GameObject Start_cam;

	// Use this for initialization
	void Start () {
		Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnButton_Start()
	{
		
		Start_cam.SetActive(false);
		UI_cam.SetActive(true);
		player.SetActive(true);
		Cursor.visible = false;


		Time.timeScale = 1;


	}
	public void OnButton_Quit()
	{
		Application.Quit();
	}
}
