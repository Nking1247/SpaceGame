using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class health : MonoBehaviour
{
    public int healthnum;
    public bool Player;
    public bool canouch;
    public GameObject part;
    HealthBarScript healthchange;
    public GameObject HealthBar;

    private void Start()
    {

        healthchange = HealthBar.GetComponent<HealthBarScript>();
    }
    void Update()
    {
        if (healthnum == 0)
        {
            if (Player)
            {
                SceneManager.LoadScene("YouHaveDied");
            }
            else
            {
                Instantiate(part, transform.position, Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
    void OnCollisionStay(Collision col)
    {
        //print(col.gameObject.name);
        if (col.gameObject.tag == "homer" && Player && canouch)
        {
            //print(col.gameObject.name);
            healthnum--;
            healthchange.HealthChange(healthnum * 100);
            //col.gameObject.GetComponent<coin>().particlespawn();
            //print(healthnum);
            Destroy(col.gameObject);
            Invoke("cancanouch", 1);
            canouch = false;

        }
        if (col.gameObject.tag == "Enemy" && Player && canouch)
        {
            //print(col.gameObject.name);
            healthnum--;
            healthchange.HealthChange(healthnum * 100);
            //col.gameObject.GetComponent<coin>().particlespawn();
            //print(healthnum);
            Invoke("cancanouch", 1);
            canouch = false;
        }

        if (col.gameObject.tag == "bullet")
        {
            //print(col.gameObject.name);
            healthnum--;
            healthchange.HealthChange(healthnum * 100);
            //col.gameObject.GetComponent<coin>().particlespawn();
            //print(healthnum);
            Destroy(col.gameObject);
            Invoke("cancanouch", 1);
            canouch = false;
        }
    }
    void cancanouch()
    {
        canouch = true;
    }
}
