using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombie_move : MonoBehaviour {

	public AudioClip sound_die;

    public GameObject _player;

    Animator animator;

    NavMeshAgent Navi;

	public bool _die;
	public float _die_count = 0.0f;
	public GameObject _point;

    // Use this for initialization
    void Start () {
		_die = false;
        Navi = GetComponent<NavMeshAgent>();
        animator = GetComponentInChildren<Animator>();
		_player = GameObject.Find ("player");
		_point = GameObject.Find ("Zombie_point");
    }
	
	// Update is called once per frame
	void Update () {

        _Zonbie();

		if (_die) {
			_die_count += 0.1f;
			if(_die_count >= 5.5f)
			{
				Destroy (gameObject);
			}

		}
	}

    void _Zonbie()
    {
        Navi.SetDestination(_player.transform.position);

        if (transform.position == Navi.destination) return;
    }

    void OnTriggerEnter(Collider coll)
    {
		if (coll.gameObject.tag == "Player") {
			
			animator.SetTrigger ("attack");
		}


		if (coll.gameObject.tag == "Fire") {
			//Navi.speed = 0;
			Navi.Stop(true);
			_die = true;
			animator.SetBool("die",_die);

			AudioSource.PlayClipAtPoint(sound_die, transform.position);




		}
    }
}