using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bullet;
    public bool canshoot;
    public Transform shootpoint;
    public int ammo;
    public int maxammo;
    public bool canreload;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canshoot)
        {
            Instantiate(bullet, shootpoint.position, transform.rotation);
            canshoot = false;
            Invoke("cancanshoot", 1);
            ammo--;
        }
        if (ammo == 0 && canreload)
        {
            canreload = false;
           CancelInvoke();
           canshoot = false;
            Invoke("reload", 3);
        }
    }
    void reload()
    {
        canreload = true;
        canshoot = true;
        ammo = maxammo;
    }
    void cancanshoot()
    {
        canshoot = true;
    }
}
