﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// this script was written by Shahram Payandeh - December 2020
// it follows all the steps which were introduced as a part of the 
// introductory video.
public class Player : MonoBehaviour
{
    [SerializeField] private    Transform groundCheckTransform;
    private bool jumpKeyWasPressed;
    private float horizontalInput;
    private Rigidbody rigidbodyComponent;
   

    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // check the key entery event
       if (Input.GetKeyDown(KeyCode.Space))
        {
            jumpKeyWasPressed = true;
        }

        horizontalInput = Input.GetAxis("Horizontal");
    }
    // FiexedUpdate is called once every physics update
    private void FixedUpdate()
    {
        
        if (jumpKeyWasPressed)
        {
            rigidbodyComponent.AddForce(Vector3.up * 5, ForceMode.VelocityChange);
            jumpKeyWasPressed = false;
        }

        rigidbodyComponent.velocity = new Vector3(horizontalInput, rigidbodyComponent.velocity.y, 0);
    }
    
}
