using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombie_move : MonoBehaviour {

    public GameObject _player;
	
    NavMeshAgent Navi;
	// Use this for initialization
	void Start () {
        Navi = GetComponent<NavMeshAgent>();
        
	}
	
	// Update is called once per frame
	void Update () {

        _Zonbie();

	}

    void _Zonbie()
    {
        Navi.SetDestination(_player.transform.position);

        if (transform.position == Navi.destination) return;
    }
}