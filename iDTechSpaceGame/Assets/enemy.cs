using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int index;
    public float speed;
    public EnemySpawner spawner;
    public Vector3 targetpos;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(3, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, spawner.waypoints[index].position, speed * Time.deltaTime);
        targetpos = spawner.waypoints[index].position;
        transform.LookAt(targetpos);
        if (Vector3.Distance(transform.position, spawner.waypoints[index].position)<=3)
        {
            index++;
            if (index == 4)
            {
                index = 0;
            }
        }
    }
}
