using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movespeed;
    public Transform Orientation;

    float horizontalInput;
    float verticalInput;

    public Vector3 moveDirection;

    Rigidbody rb;


    private void SpeedControl()
    {
        Vector3 flatvel = new Vector3(rb.velocity.x, 0, rb.velocity.z);

        if(flatvel.magnitude> movespeed)
        {
            Vector3 limitedVel = flatvel.normalized * movespeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z);
        }
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        MyInput(); 
        SpeedControl();
    }
    private void FixedUpdate()
    {   
        MovePlayer();
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        moveDirection = Orientation.forward * verticalInput + Orientation.right * horizontalInput;
        if(moveDirection.magnitude == 0)
        {
            rb.velocity = new Vector3(0f, 0f, 0f);
        }

        rb.AddForce(moveDirection.normalized * movespeed * 50f, ForceMode.Force);
    }
}
