using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private CharacterController cc;
    public Animator animator;
    public float velocity;

    public void Awake()
    {
        cc = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    public void Update()
    {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");
        float mouseX = Input.GetAxis("Mouse X");

        //Movement
        Vector3 movement = transform.forward * movZ;
        
        cc.Move(movement * velocity * Time.deltaTime);
        transform.Rotate(0, movX * 2f, 0);

        //Animator
        if (Input.GetButton("Horizontal") || (movZ > 0f && movZ <=1f))
        {
            animator.SetBool("Run", true);
        }   
        else if (movZ < 0f && movZ >= -1f)
        {
            animator.SetBool("RunBack", true);
        }
        else
        {
            animator.SetBool("Run", false);
            animator.SetBool("RunBack", false);
        }
    }
}
