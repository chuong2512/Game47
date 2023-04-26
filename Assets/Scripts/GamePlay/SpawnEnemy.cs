using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public Transform[] points;
    public GameObject[] enemies;

    public float time = 2, timeCount = 2;


    private void Spawn()
    {
        var enemy = Instantiate(enemies[Random.Range(0, enemies.Length)]);

        enemy.transform.position = points[Random.Range(0, points.Length)].position;
    }

    void Update()
    {
        if (GameManager.Instance.currentState == State.Playing)
        {
            time -= Time.deltaTime;

            if (time <= 0)
            {
                time = timeCount;

                Spawn();
            }
        }
    }
}