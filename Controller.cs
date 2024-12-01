using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class Controller : MonoBehaviour
{
    private  float speed;

    private float runSpeed;

    private float walkSpeed;

    private float jumpHeight;

    private Vector3 dir;

    private float gravity = 9.81f;


    private CharacterController _characterController;
    // Start is called before the first frame update


    public float WalkSpeed
    {
        set
        {
            walkSpeed = value;
            runSpeed = walkSpeed * 1.5f;
        }
    }
    public float JumpHeight
    {
        set
        {
            jumpHeight = value;
        }
    }
    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

            dir.x = moveH * speed;
            dir.z = moveV * speed;
            dir = transform.TransformDirection(dir);

        if (_characterController.isGrounded)
        {

            if (Input.GetKey(KeyCode.LeftShift))
            {
                speed = runSpeed;
            }
            else
            {
                speed = walkSpeed;
            }
            dir.y = 0f;
            
        }

        if (_characterController.isGrounded && Input.GetKey(KeyCode.Space))
        {
            dir.y += Mathf.Sqrt(2f * gravity * jumpHeight);
        }


        dir.y -= gravity * Time.deltaTime;
        _characterController.Move(dir  * Time.deltaTime);
        
    }
}
