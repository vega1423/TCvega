using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//게임 클리어
public class target_find : MonoBehaviour {
	public GameObject _clear;
	public GameObject _UI;
	public float a = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!transform.Find("target"))
        {
            //Debug.Log("클리어");

			_clear.SetActive (true);
			_UI.SetActive (false);

            Time.timeScale = 0;
            //Destroy(gameObject);

			a += 0.1f;
			if (a >= 6.0f) {
				_clear.SetActive (false);
				Application.LoadLevel ("zzzzzz");
			}
        }
	}
}
