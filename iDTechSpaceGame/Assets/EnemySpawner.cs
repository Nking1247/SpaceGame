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
                Instantiate(EnemyA1, transform.position, Quaternion.identity);
                Instantiate(EnemyA1, transform.position, Quaternion.identity);
                Instantiate(EnemyA2, transform.position, Quaternion.identity);
                Instantiate(EnemyA2, transform.position, Quaternion.identity);
            }
            else if (groupType == 'B')
            {
                Instantiate(EnemyB1, transform.position, Quaternion.identity);
                Instantiate(EnemyB1, transform.position, Quaternion.identity);
                Instantiate(EnemyB2, transform.position, Quaternion.identity);
                Instantiate(EnemyB3, transform.position, Quaternion.identity);
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
