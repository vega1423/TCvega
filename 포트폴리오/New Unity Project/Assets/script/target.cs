using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour {
    public AudioClip sound_eat;
	public GameObject _bullet_plus;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider coll)
    {

		if (coll.gameObject.tag == "Player" &&transform.gameObject.tag == "target")
        {
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(sound_eat, transform.position);

        }
		if (coll.gameObject.tag == "Player" && transform.gameObject.tag == "bullet") {
			
			Destroy(gameObject);
			AudioSource.PlayClipAtPoint(sound_eat, transform.position);
			_bullet_plus.GetComponent<_ShotGun> ().gun_count += 1;
		}
    }
}
