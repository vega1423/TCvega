using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _ShotGun : MonoBehaviour {

    //CharacterController pcController;
    Animator animator;

    public AudioClip sndCilp;

    public GameObject _gun_fire;
    public float _shot_count;
    public bool _shooting;
    public float _shot_count_max;
    float _shot_count_min = 0.0f;
   


    
    // Use this for initialization
    void Start () {
        //pcController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
        
        _shooting = false;
        _shot_count = 0.0f;
        _gun_fire.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !_shooting)
        {
            AudioSource.PlayClipAtPoint(sndCilp, transform.position);
            _shooting = true;
        }

        if (_shooting)
        {
            
            _shot_count += 0.1f;
            
            _gun_fire.SetActive(true);

        }

        if (_shot_count >= _shot_count_max/2.0f)
        {
            _gun_fire.SetActive(false);
        }

        if ( _shot_count >= _shot_count_max)
        {
            _shooting = false;
            
            _shot_count = _shot_count_min;
            
        }

        

        


        animator.SetBool("shot", _shooting);
    }
}
