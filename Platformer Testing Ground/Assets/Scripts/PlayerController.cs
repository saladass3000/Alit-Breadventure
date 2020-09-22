﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    public float moveSpeed;
    public float jumpForce;
    public float gravityScale = 5f;

    private Vector3 moveDirection;
    public CharacterController charCont;

    private Camera cam;
    public GameObject playerModel;
    public float rotateSpeed = 5f;

    public Animator anim;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        float yStore = moveDirection.y;
        //moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveDirection = (transform.forward * Input.GetAxisRaw("Vertical")) + (transform.right * Input.GetAxisRaw("Horizontal"));
        moveDirection.Normalize();
        moveDirection = moveDirection * moveSpeed;
        moveDirection.y = yStore;

        if (charCont.isGrounded) 
    {
            moveDirection.y = 0f;

        if (Input.GetButtonDown("Jump"))
        {
            moveDirection.y = jumpForce;
        }

    }

        moveDirection.y += Physics.gravity.y * gravityScale * Time.deltaTime;
        //transform.position = transform.position + (moveDirection * Time.deltaTime * moveSpeed);

        charCont.Move(moveDirection * Time.deltaTime);

        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") !=0)
        {
            transform.rotation = Quaternion.Euler(0f, cam.transform.rotation.eulerAngles.y, 0f);
            Quaternion newRotation = Quaternion.LookRotation(new Vector3(moveDirection.x, 0f, moveDirection.z));
            // playerModel.transform.rotation = newRotation;
            playerModel.transform.rotation = Quaternion.Slerp(playerModel.transform.rotation, newRotation, rotateSpeed * Time.deltaTime);
        }

        anim.SetFloat("Speed", Mathf.Abs( moveDirection.x) + Mathf.Abs(moveDirection.z));
        anim.SetBool("Grounded", charCont.isGrounded);
    }
}
