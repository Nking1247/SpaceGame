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

    //For Shooting Position
    public Camera shootCam;
    public Transform shootTransform;
    public float shootAngle = 15;
    public float shootDistance = 100;
    public LayerMask shootMask;


    Vector3 crossHairPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && canshoot)
        {

            Vector3 crosshairPosition = new Vector3(Screen.width / 2, Screen.height / 2);

            Ray camRay = shootCam.ScreenPointToRay(crosshairPosition);
            if (Physics.Raycast(camRay, out RaycastHit hit, shootDistance, shootMask))
            {
                Vector3 targetDirection = hit.point - shootTransform.position;
                Vector3 curDir = shootTransform.forward;
                Vector3 camDirection = Vector3.RotateTowards(transform.forward, targetDirection, shootAngle * Mathf.PI / 180, 0);
                shootTransform.forward = camDirection;
                Instantiate(bullet, shootTransform.position, shootTransform.rotation);
                shootTransform.forward = curDir;

            }
            else
            {
                Instantiate(bullet, shootpoint.position, transform.rotation);
            }
            
            //Instantiate(bullet, shootpoint.position, transform.rotation);
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
