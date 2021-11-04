using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float MaxSpeedUp = 20;
    public float UpSpeed = 1f;
    public float DownSpeed = 1f;
    public float UpCount = 0;
    public float SpeedOfRotation;
    public float CountSpeed = 10;

    private bool isDead;
    private bool isGoingUp;

    private int zRotation = 0;

    private Animator anim;
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.flipX = false;
        spriteRenderer.flipY = false;
        isDead = false;
    }
    private void Update()
    {
        if (StateManager.State == StateManager.States.End)
        {
            if(spriteRenderer.flipX == false)
            {
                transform.rotation = Quaternion.Euler(Vector3.zero);
                spriteRenderer.flipX = true;
                spriteRenderer.flipY = true;
            }
        }
        if (StateManager.State == StateManager.States.End || StateManager.State == StateManager.States.Begin)
        {
            if(anim.GetBool("isAlive") == true)
            {
                anim.SetBool("isAlive", false);
                isDead = true;
            }
            var reachedTheGround = transform.position.y < -3.6f;
            if (isDead && !reachedTheGround)
            {
                transform.position += Vector3.down * Time.deltaTime * DownSpeed;
                //transform.rotation = Quaternion.Euler(0, 0, -30);
            }
            return;
        }
        else if(anim.GetBool("isAlive") == false && StateManager.State == StateManager.States.Play)
        {
            anim.SetBool("isAlive", true);
            return;
        }
        CheckForInput();
        MoveDown();
    }

    void CheckForInput()
    {
        MoveUpAndRotate();

        if (UpCount >= MaxSpeedUp)
        {
            isGoingUp = false;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        if (Input.GetMouseButtonDown(0))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            isGoingUp = true;
            UpCount = 0;
        }
    }

    void MoveUpAndRotate()
    {
        if (isGoingUp)
        {
            transform.position += Vector3.up * Time.deltaTime * UpSpeed;
            transform.rotation = Quaternion.Euler(0, 0, zRotation);
            UpCount+=Time.deltaTime* CountSpeed;
            if (zRotation < 30)
                zRotation += 4;
        }
    }

    void MoveDown()
    {
        if (!isGoingUp)
        {
            transform.position += Vector3.down * Time.deltaTime * DownSpeed;
            transform.rotation = Quaternion.Euler(0, 0, zRotation);
            if (zRotation > -30)
                zRotation -= 4;
        }
    }
}
