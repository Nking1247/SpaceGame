using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flier : MonoBehaviour
{
    public GameObject player;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(4, 6);
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed*Time.deltaTime);
    }

}










//Flying Homer. More like flying Homer Simpson