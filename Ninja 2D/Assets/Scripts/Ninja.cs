using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : MonoBehaviour
{
    public float moveSpeed = 40f;
    float horizontalMove = 0f;

    [SerializeField]
    private float jumpForce = 400f;

    [SerializeField]
    private float crouchSpeed = 20f;
    //ol jump = false;
    bool crouched = false;

    private Rigidbody2D rbNinja;
    public Animator animator;

    private void Awake()
    {
        rbNinja = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;

        if (Input.GetKeyDown("space"))
        {
            Jump();
            animator.SetBool("isJumping", true);
        }

        //if (Input.GetKeyDown("c"))
        //{
        //    crouched = true;   
        //}

        //if (Input.GetKeyUp("c"))
        //{
        //    crouched = false;
        //}

        //checkCrouch();

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }

    private void FixedUpdate()
    {
        MovePlayer(horizontalMove * Time.fixedDeltaTime);
    }

    private void MovePlayer(float move)
    {
        rbNinja.velocity = new Vector2(move, 0);
        //animator.SetBool("isJumping", false);
    }

    private void Jump()
    {
        rbNinja.AddForce(new Vector2(0f, jumpForce));
    }

    //private void checkCrouch()
    //{
    //    if (crouched)
    //    {
    //        MovePlayer(crouchSpeed * Time.deltaTime);
    //    }
    //}
}
