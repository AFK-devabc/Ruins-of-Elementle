using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private float jumpPower;
    [SerializeField] private LayerMask groundLayer;

    private Rigidbody2D body;

    private Animator animator;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float HorizontalInput = Input.GetAxis("Horizontal");

        if (HorizontalInput > 0.01f)
        {
            transform.localScale  =  Vector3.one;
        }
        else if (HorizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }


        body.velocity = new Vector2(HorizontalInput * Speed, body.velocity.y);

        if (Input.GetKey(KeyCode.Space) )
            Jump();
    }

    private void Jump()
    {

    }


    private void GravityControl()
    {
       
    }

}
