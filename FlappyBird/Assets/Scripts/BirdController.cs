using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float Speed = 1f;

    private void Update()
    {
        CheckForInput();
        CheckIfIsFalling();
    }

    void CheckForInput()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0))
        {
            Speed = 1;
        }
        if (Input.GetMouseButton(0))
        {
            transform.position += Vector3.up * Time.deltaTime * Speed;
            Speed += 0.03f;
        }
    }
    void CheckIfIsFalling()
    {
        if (!Input.GetMouseButton(0))
        {
            transform.position += Vector3.down * Time.deltaTime * Speed;
            Speed += 0.03f;
        }
    }
}
