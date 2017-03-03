using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_ray : MonoBehaviour {
    private RaycastHit rayHit;
    private Ray ray;

    public float ray_max;

    public Camera cam;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        _camera_Raycast();

    }


    void _camera_Raycast()
    {
        //ray = cam.ScreenPointToRay(Input.mousePosition);
        ray = cam.ViewportPointToRay(new Vector3(0.5f,0.5f,0f));

        if (Physics.Raycast(ray, out rayHit, ray_max))
        {
            //Transform objectHit = hit.transform;

            //Debug.DrawLine(ray.origin, rayHit.point, Color.green);
            Debug.DrawLine(ray.origin, rayHit.point, Color.green);
            Debug.Log("체크->" + rayHit.transform.name);
        }
        else
        {
            Debug.DrawRay(ray.origin, ray.direction*100, Color.red);
        }
    }
}
