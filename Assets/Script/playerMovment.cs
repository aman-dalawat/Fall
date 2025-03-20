using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class playerMovment : MonoBehaviour
{
    public characterController controller;
    public Animator animator;
    public Button jumpButton; // reference to jump UI button
    public  Button moveLeftButton; // reference to move left UI button
    public Button moveRightButton; // reference to move right UI button

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    bool moveLeft = false;
    bool moveRight = false;

    public AudioSource audioSource;


    

 

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
      Movement();
    }

    public void pointerDownLeft()
    {
        moveLeft = true;
    }
    public void pointerUpleft()
    {
        moveLeft = false;
    }
    public void pointerDownRight()
    {   
        moveRight = true;
    }
    public void pointerUpRight()
    {       
        moveRight = false;
    }
    public void pointerDownJump()
    {
        jump = true;
        animator.SetBool("isJumping", true);
    }
    public void pointerUpJump()
    {
        jump = false;
        animator.SetBool("isJumping", false);
    }
    public void OnLanding()
    {
        animator.SetBool("isJumping", false);
    }

    void Movement()
    {
        if (moveLeft)
        {
            horizontalMove = -runSpeed;
            
        }
        else if (moveRight)
        {
            horizontalMove = runSpeed;
           
        }
        else
        {
            horizontalMove = 0f;
        }

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
       

        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            // Check for keyboard input
        if (Input.GetKey(KeyCode.A))
        {
            moveLeft = true;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveRight = true;
        }
        else
        {
             moveLeft = false;
             moveRight = false;
        }
        }
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
            animator.SetBool("isJumping", true);
        }
    }

    void FixedUpdate()
    {
      
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

   

    

    
}