using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    private GameObject[] instances = null;

    public int count = 10;
    public float maxRange = 1000f;

    public float maxEulerOffset = 10f;
    public GameObject asteroid = null;

    [ContextMenu("Generate")]
    public void Generate()
    {
        if (instances != null)
        {
            foreach (GameObject o in instances)
            {
                DestroyImmediate(o);
            }
        }
        

        instances = new GameObject[count];
        Vector3 dir;

        for (int i = 0; i < count; i++)
        {
            instances[i] = Instantiate(asteroid, transform.position, transform.rotation);
            dir = Random.insideUnitSphere;

            Vector3 euler = transform.eulerAngles;
            euler.x += Random.Range(-maxEulerOffset, maxEulerOffset);
            euler.y += Random.Range(-maxEulerOffset, maxEulerOffset);
            euler.z += Random.Range(-maxEulerOffset, maxEulerOffset);


            Vector3 scale = Vector3.one * Random.Range(1, 5);

            instances[i].transform.position += dir * Random.Range(0, maxRange);
            instances[i].transform.localScale = scale;
            instances[i].transform.rotation = Quaternion.Euler(euler);
            instances[i].transform.parent = transform;


        }

    }


}
