using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolSystem : MonoBehaviour
{
    public List<GameObject> Obstacles = new List<GameObject>();
    public List<GameObject> DeactivatedObstacles = new List<GameObject>();
    private int timer = 0;
    public GameObject TriggerScore;

    private void Awake()
    {
        CreateAllObstacles();
    }

    private void FixedUpdate()
    {
        if (StateManager.State == StateManager.States.End || StateManager.State == StateManager.States.Begin)
            return;
        if (timer == 110)
        {
            timer = 0;
            Pool();
        }
        timer++;
    }

    private void Pool()
    {
        if (DeactivatedObstacles.Count != 0)
        {
            var randomIndexUp = Random.Range(0, DeactivatedObstacles.Count - 1);
            var randomUpPosition = Random.Range(6f, 8f);
            DeactivatedObstacles[randomIndexUp].GetComponent<SpriteRenderer>().flipY = true;
            MakeObjectReadyForPool(randomIndexUp, randomUpPosition);

            var randomIndexDown = Random.Range(0, DeactivatedObstacles.Count - 1);
            var randomDownPosition = Random.Range(-6f, -3f);
            DeactivatedObstacles[randomIndexDown].GetComponent<SpriteRenderer>().flipY = false;
            DeactivatedObstacles[randomIndexDown].transform.GetChild(0).gameObject.SetActive(true);
            MakeObjectReadyForPool(randomIndexDown, randomDownPosition);
        }
    }

    private void MakeObjectReadyForPool(int randomIndex, float randomPosition)
    {
        DeactivatedObstacles[randomIndex].transform.position = new Vector3(4.4f, randomPosition, 0);
        DeactivatedObstacles[randomIndex].SetActive(true);
        DeactivatedObstacles.Remove(DeactivatedObstacles[randomIndex]);
    }

    private void CreateAllObstacles()
    {
        for (int i = 0; i < Obstacles.Count; i++)
        {
            var obj = Instantiate(Obstacles[i], new Vector3(-4, 0, 0), Quaternion.identity);
            obj.SetActive(false);
            DeactivatedObstacles.Add(obj);
        }
    }
}
