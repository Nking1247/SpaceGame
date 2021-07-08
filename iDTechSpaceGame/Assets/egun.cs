using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egun : MonoBehaviour
{
    public GameObject bullet;
    public bool canshoot;
    public Transform shootpoint;
    public float timebetweenshots;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        InvokeRepeating("shoot", timebetweenshots, timebetweenshots);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform.position);
    }
    void shoot()
    {
        Instantiate(bullet, shootpoint.position, transform.rotation);
        canshoot = false;
        Invoke("cancanshoot", 1);
    }
    void cancanshoot()
    {
        canshoot = true;
    }
}
