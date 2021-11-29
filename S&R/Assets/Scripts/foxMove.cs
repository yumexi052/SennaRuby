using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(AudioSource))]
public class foxMove : MonoBehaviour
{
    public float speed = 1.0f;
    public float rotationSpeed = 100.0f;

    public Animator animator;//Animator Controller
    private CharacterController characterController;
    private Vector3 moveDirection;
    private Vector3 rotationDirection;
    private float gravity = 9.8f;
    private float vSpeed = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Vertical") == 0 && Input.GetAxis("Horizontal") == 0) 
        {
            animator.SetBool("isWalk", false);
        }
        else 
        {
            Move();
        }
    }

    private void Move()
    {
        animator.SetBool("isWalk", true);
        float moveZ = Input.GetAxis("Vertical");
        float rotation = Input.GetAxis("Horizontal");
        moveDirection = new Vector3(0, 0, moveZ);
        moveDirection *= speed;
        moveDirection = transform.TransformDirection(moveDirection);

        rotationDirection = new Vector3(0, rotation, 0);
        transform.Rotate(this.rotationDirection);

        vSpeed -= gravity * Time.deltaTime;
        moveDirection.y = vSpeed;
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
