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
    void Update()
    {
        if (healthnum == 0)
        {
            if (Player)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
            else
            {
                Instantiate(part, transform.position, Quaternion.identity);
                gameObject.SetActive(false);
            }
        }
    }
    void OnCollisionEnter(Collision col)
    {
        print(col.gameObject.name);
        if (col.gameObject.tag == "homer" && Player && canouch)
        {
            print(col.gameObject.name);
            healthnum--;
            //col.gameObject.GetComponent<coin>().particlespawn();
            print(healthnum);
            Destroy(col.gameObject);
            Invoke("cancanouch", 1);
            canouch = false;
        }
        if (col.gameObject.tag == "bullet")
        {
            print(col.gameObject.name);
            healthnum--;
            //col.gameObject.GetComponent<coin>().particlespawn();
            print(healthnum);
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
