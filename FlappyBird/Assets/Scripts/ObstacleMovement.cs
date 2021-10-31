using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public float Speed = 1.5f;

    void Update()
    {
        if (StateManager.State == StateManager.States.End || StateManager.State == StateManager.States.Begin)
            return;
        transform.position += Speed * Time.deltaTime * Vector3.left;
    }
}
