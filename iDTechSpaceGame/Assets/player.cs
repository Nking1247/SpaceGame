using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float speed;
    public int parts;
    public int partsrequired;
    public GameObject portal;
    public GameObject portalpoint;
    public Rigidbody rb;
    public float xsensitivity;
    public float ysensitivity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude > 1)
        {
            rb.velocity = rb.velocity.normalized * speed;
        }
        if (parts >= partsrequired)
        {
            partsrequired = 10000;
            Instantiate(portal, portalpoint.transform.position, Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeForce(Vector3.forward * -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeForce(Vector3.right * speed);
        }
        float y = Input.GetAxis("Mouse X");
        float x = Input.GetAxis("Mouse Y") * ysensitivity;
        transform.Rotate(Vector3.up, y * xsensitivity);
        transform.Rotate(Vector3.right, -x);
    }
    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "part")
        {
            parts++;
            //col.gameObject.GetComponent<coin>().particlespawn();
            print(parts);
            Destroy(col.gameObject);
        }
        if (col.gameObject.tag == "portal")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
}
