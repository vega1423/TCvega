using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombie_point : MonoBehaviour {
	public GameObject _zombie1;
	public GameObject _zombie2;

	public bool _summon1;
	public bool _summon2;
	public int _summon1_count;
	public int _summon2_count;

	public float _time;
	// Use this for initialization
	void Start () {
		
		_time = Time.deltaTime;
		_summon1 = false;
		_summon2 = false;

		_summon1_count = 0;
		_summon2_count = 0;
		StartCoroutine ("zombie_summon",1.0f);
		StartCoroutine ("zombie_summon2", 30.0f);
	}	
	
	// Update is called once per frame

	void Update()
	{
		_time += Time.deltaTime;
		if (Input.GetKeyDown (KeyCode.Alpha9)) {

			--_summon1_count;
			_summon1 = false;
			StartCoroutine ("zombie_summon",1);
		}
		if (Input.GetKeyDown (KeyCode.Alpha0)) {

			--_summon2_count;
			_summon2 = false;
			StartCoroutine ("zombie_summon2",1);
		}



	}

	IEnumerator zombie_summon (float summon_Time)
	{
		

			yield return new WaitForSeconds (summon_Time);
			Instantiate (_zombie1, new Vector3 (transform.position.x, transform.position.y, transform.position.z), new Quaternion (0, 0, 0, 0));
			++_summon1_count;

			StartCoroutine ("zombie_summon", 20.0f);
		
	}


	IEnumerator zombie_summon2(float summon_Time2)
	{
		

			yield return new WaitForSeconds (summon_Time2);
			Instantiate (_zombie2, new Vector3 (transform.position.x, transform.position.y, transform.position.z), new Quaternion (0, 0, 0, 0));
			++_summon2_count;

			
			StartCoroutine ("zombie_summon2", 30.0f);


	}
}
