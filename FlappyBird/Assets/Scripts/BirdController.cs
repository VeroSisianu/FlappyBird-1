using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float UpSpeed = 1f;
    public float DownSpeed = 1f;
    public float UpCount = 0;


    private bool isGoingUp;

    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (StateManager.State == StateManager.States.End || StateManager.State == StateManager.States.Begin)
        {
            if(anim.GetBool("isAlive") == true)
                anim.SetBool("isAlive", false);
            return;
        }
        else if(anim.GetBool("isAlive") == false && StateManager.State == StateManager.States.Play)
        {
            anim.SetBool("isAlive", true);
            return;
        }
        CheckForInput();
        CheckIfIsFalling();
    }

    void CheckForInput()
    {
        //if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0))
        //{
        //    Speed = 1;
        //}
        //if (Input.GetMouseButton(0))
        //{
        //    transform.position += Vector3.up * Time.deltaTime * Speed;
        //    Speed += 0.03f;
        //}

        if(isGoingUp)
        {
            transform.position += Vector3.up * Time.deltaTime * UpSpeed;
            UpCount++;
        }

        if (UpCount == 8)
        {
            isGoingUp = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            isGoingUp = true;
            UpCount = 0;
        }
    }
    void CheckIfIsFalling()
    {
        if (!isGoingUp)
        {
            transform.position += Vector3.down * Time.deltaTime * DownSpeed;
        }
    }
}
