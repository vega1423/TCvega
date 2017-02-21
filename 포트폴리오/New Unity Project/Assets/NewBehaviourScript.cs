using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float runSpeed = 6.0f;
    public float rotationSpeed = 360f;

    public CharacterController pcController;
    public Vector3 direction;

    public Animator animator;

    // Use this for initialization
    void Start()
    {
        pcController = GetComponent<CharacterController>();
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //CharacterControl_Slerp();
        animator.SetFloat("Speed", pcController.velocity.magnitude);
    }

    //private void CharacterControl_Slerp()
    //{
    //    Vector3 direction = new Vector3(Input.GetAxis("Horizontal"),
    //    0,
    //    Input.GetAxis("Vertical"));
    //    if (direction.sqrMagnitude > 0.01f)
    //    {
    //        Vector3 forward = Vector3.Slerp(
    //            transform.forward,
    //            direction,
    //            rotationSpeed * Time.deltaTime / Vector3.Angle(transform.forward, direction));

    //        transform.LookAt(transform.position + forward);



    //    }

    //    pcController.Move(direction * runSpeed * Time.deltaTime);

    //    animator.SetFloat("Speed", pcController.velocity.magnitude);
    //}
}
