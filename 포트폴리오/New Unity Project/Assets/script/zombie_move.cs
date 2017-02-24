using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombie_move : MonoBehaviour {

    public GameObject _player;
	//public float _zomSpeed = 0.0f;
	//public float _speed;

    Animation Ani;
    NavMeshAgent Navi;
	// Use this for initialization
	void Start () {
        Navi = GetComponent<NavMeshAgent>();
        Ani = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update () {
        /*if(_speed >= _zomSpeed)
		{
			_zomSpeed += 0.1f;
			transform.Translate (Vector3.forward*_zomSpeed*Time.deltaTime);
		}


		transform.Translate (Vector3.forward*_zomSpeed*Time.deltaTime);*/

        _Zonbie();
	}

    void _Zonbie()
    {
        Navi.SetDestination(_player.transform.position);

        if (transform.position == Navi.destination) return;
    }
}