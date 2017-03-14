using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_ray : MonoBehaviour {
    private RaycastHit rayHit;
    private Ray ray;

    public bool _shooting2;

    public float ray_max;

    public Camera cam;

    public GameObject _fire;

    
    // Use this for initialization
    void Start () {
        _shooting2 = false;

    }
	
	// Update is called once per frame
	void Update () {
        _camera_Raycast();

    }


    void _camera_Raycast()
    {
        //ray = cam.ScreenPointToRay(Input.mousePosition);
        ray = cam.ViewportPointToRay(new Vector3(0.5f,0.5f,0f));

        if (Physics.Raycast(ray, out rayHit, ray_max) && !(rayHit.transform.tag =="target"))
        {
           
            if (_shooting2)
            {
                Instantiate(_fire, new Vector3(rayHit.point.x, rayHit.point.y, rayHit.point.z), new Quaternion(0, 0, 0, 0));
               
            }
            
        }
        else
        {
            Debug.DrawRay(ray.origin, ray.direction*100, Color.red);
        }

    }
}
