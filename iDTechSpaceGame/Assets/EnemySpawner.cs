using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [Header("Set the group type to be exactly 'A' or 'B'.\nDon't forget the collider must be tagged as 'Player' for the spawn to be triggered.")]
    public GameObject EnemyA1;
    public GameObject EnemyA2;
    public GameObject EnemyB1;
    public GameObject EnemyB2;
    public GameObject EnemyB3;
    public char groupType;
    bool coolDown;
    public Transform[] waypoints;
    public GameObject currentenemy;

    IEnumerator timer() 
    {
        yield return new WaitForSeconds(30);
        coolDown = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.tag == "Player" && !coolDown)
        {
            if (groupType == 'A')
            {
                currentenemy = Instantiate(EnemyA1, transform.position, Quaternion.identity);
                currentenemy.GetComponent<enemy>().spawner = this;
                currentenemy = Instantiate(EnemyA1, transform.position, Quaternion.identity);
                currentenemy.GetComponent<enemy>().spawner = this;
                Instantiate(EnemyA2, transform.position, Quaternion.identity);
                Instantiate(EnemyA2, transform.position, Quaternion.identity);
            }
            else if (groupType == 'B')
            {
                Instantiate(EnemyB1, transform.position, Quaternion.identity);
                Instantiate(EnemyB1, transform.position, Quaternion.identity);
                Instantiate(EnemyB2, transform.position, Quaternion.identity); //I would like to change this to A1 to work with the "Rare" Spawner
                Instantiate(EnemyB3, transform.position, Quaternion.identity); //I would like to change this to A1 to work with the "Rare" Spawner
            }
            else
            {
                Debug.LogError("Group type not set correctly.");
            }
            coolDown = true;
            timer();
        }

    }

}
