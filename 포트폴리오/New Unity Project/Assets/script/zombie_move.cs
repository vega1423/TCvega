using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombie_move : MonoBehaviour {

    public GameObject _player;

    Animator animator;

    NavMeshAgent Navi;

    // Use this for initialization
    void Start () {
        Navi = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
       
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

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            animator.SetTrigger("attack");
        }
    }
}