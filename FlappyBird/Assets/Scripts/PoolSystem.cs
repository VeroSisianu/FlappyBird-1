using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolSystem : MonoBehaviour
{
    public List<GameObject> Obstacles = new List<GameObject>();
    public List<GameObject> DeactivatedObstacles = new List<GameObject>();
    private float[] randomYPositions = new float[2];
    private int timer = 0;

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
            var random = Random.Range(0, DeactivatedObstacles.Count - 1);

            randomYPositions[0] = Random.Range(3f, 5f);
            randomYPositions[1] = Random.Range(-3f, -1f);

            var index = Random.Range(0, 2);

            if (randomYPositions[index] >= 3)
                DeactivatedObstacles[random].GetComponent<SpriteRenderer>().flipY = true;
            else
                DeactivatedObstacles[random].GetComponent<SpriteRenderer>().flipY = false;

            DeactivatedObstacles[random].transform.position = new Vector3(4.4f, randomYPositions[index], 0);
            DeactivatedObstacles[random].SetActive(true);
            DeactivatedObstacles.Remove(DeactivatedObstacles[random]);
        }
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
