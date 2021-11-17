using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public bool isRunningMe;
    public Animator anim;
    public GameObject player;

    public float walkSpeed = 3;
    public float runSpeed = 7;

    public float jumpSpeed = 5;
   


  
    public void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            Run();
        }

        if (Input.GetKeyDown("down"))
        {
            Walk();
        }
        if (Input.GetKeyDown("w"))
        {
            Run();
        }

        if (Input.GetKeyDown("s"))
        {
            Walk();
        }

        if (Input.GetKeyDown("space"))
        {
        jump();
        }

         


        void Run()
        {
            anim.SetBool("isRunning", false);
            player.GetComponent<PlayerMovement>().currantSpeed = runSpeed;
        }
        void Walk()
        {
            anim.SetBool("isRunning", true);
            player.GetComponent<PlayerMovement>().currantSpeed = walkSpeed;
        }
       
        void jump()
        {
           //Debug.Log("jump");
            anim.SetTrigger("Jump");

           // player.GetComponent<Rigidbody>().velocity += jumpSpeed * Vector3.up;
        }

         void Start()
        {
            Run();
        }
    }
}