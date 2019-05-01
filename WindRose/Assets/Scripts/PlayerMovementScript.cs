using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    public CharacterController playerController;
    private Vector3 moveDirection;
    public float gravityScale;
    private Animator Anim;
    private float moving;
    private float moving2;
    

    void Start()
    {
        Anim = GetComponent<Animator>();
        playerController = GetComponent<CharacterController>();
    }

    void Update()
    {
        moving = Input.GetAxis("Vertical");
        moving2 = Input.GetAxis("Horizontal");

        Move();
    }

    public void Move()
    {
        Anim.SetFloat("Speed", moving);
        Anim.SetFloat("Speed2", moving2);
        float yStore = moveDirection.y;
        moveDirection = (transform.forward * Input.GetAxis("Vertical")) + (transform.right * Input.GetAxis("Horizontal"));
        moveDirection = moveDirection.normalized * moveSpeed;
        moveDirection.y = yStore;

        if (playerController.isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                Anim.SetTrigger("Jump");
                moveDirection.y = jumpHeight;
            }
        }

        moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale * Time.deltaTime);
        playerController.Move(moveDirection * Time.deltaTime);
    }
}
