using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerObstacleDeactivation : MonoBehaviour
{
    public PoolSystem ThePoolSystem;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            collision.gameObject.SetActive(false);
            ThePoolSystem.DeactivatedObstacles.Add(collision.gameObject);
        }
    }
}
