using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : MonoBehaviour
{
    public float moveSpeed = 40f;
    float horizontalMove = 0f;

    private Rigidbody2D rbNinja;
    public Animator animator;

    private void Awake()
    {
        rbNinja = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * moveSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
    }

    private void FixedUpdate()
    {
        MovePlayer(horizontalMove * Time.fixedDeltaTime);
    }

    private void MovePlayer(float move)
    {
        rbNinja.velocity = new Vector2(move, 0);
    }
}
