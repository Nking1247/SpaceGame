using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Vector3[] EnemySpawnGroups;
    public GameObject EnemyA1;
    public GameObject EnemyA2;
    public GameObject EnemyB1;
    public GameObject EnemyB2;
    public GameObject EnemyB3;

    private void Start()
    {
        for(int i = EnemySpawnGroups.Length - 1; i >= 0; i--)
        {
            if(i % 2 == 0)
            {
                Instantiate(EnemyB1, EnemySpawnGroups[i] + new Vector3(2,0,0), Quaternion.identity);
                Instantiate(EnemyB1, EnemySpawnGroups[i] + new Vector3(-2, 0, 0), Quaternion.identity);
                Instantiate(EnemyB2, EnemySpawnGroups[i] + new Vector3(2, 4, 0), Quaternion.identity);
                Instantiate(EnemyB3, EnemySpawnGroups[i] + new Vector3(-2, 4, 0), Quaternion.identity);
            }
            else
            {
                Instantiate(EnemyA1, EnemySpawnGroups[i] + new Vector3(2, 0, 0), Quaternion.identity);
                Instantiate(EnemyA1, EnemySpawnGroups[i] + new Vector3(-2, 0, 0), Quaternion.identity);
                Instantiate(EnemyA2, EnemySpawnGroups[i] + new Vector3(2, 4, 0), Quaternion.identity);
                Instantiate(EnemyA2, EnemySpawnGroups[i] + new Vector3(-2, 4, 0), Quaternion.identity);
            }
        }
    }
}
