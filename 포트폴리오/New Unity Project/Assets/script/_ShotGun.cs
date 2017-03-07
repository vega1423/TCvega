using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _ShotGun : MonoBehaviour {

    //CharacterController pcController;
    Animator animator;

    public AudioClip soundCilp;
	public AudioClip soundCilp2;

    public GameObject _gun_fire;
    public float _shot_count;
    public bool _shooting;
    public float _shot_count_max;
    float _shot_count_min = 0.0f;
	public int gun_count;


	public GameObject T_gun_count;

    // Use this for initialization
    void Start () {
        //pcController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();

		T_gun_count.GetComponent<TextMesh> ().text = gun_count.ToString();

        _shooting = false;
        _shot_count = 0.0f;
        _gun_fire.SetActive(false);
        _shot_count_max = 10.0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Mouse0) && !_shooting && gun_count!=0)
        {
            AudioSource.PlayClipAtPoint(soundCilp, transform.position);
            _shooting = true;
            transform.parent.GetComponent<Camera_ray>()._shooting2 = _shooting;
			gun_count -= 1;

        }
		T_gun_count.GetComponent<TextMesh>().text = gun_count.ToString();
		if (Input.GetKeyDown(KeyCode.Mouse0) && gun_count == 0)
		{
			AudioSource.PlayClipAtPoint(soundCilp2, transform.position);
		}


        if (_shooting)
        {
            
            _shot_count += 0.1f;
            
            _gun_fire.SetActive(true);
           

        }
        if (_shot_count >= 0.3f)
        {
            transform.parent.GetComponent<Camera_ray>()._shooting2 = false;
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
