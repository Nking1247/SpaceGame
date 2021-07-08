using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class respawn : MonoBehaviour
{
    // Start is called before the first frame update

    public void Respawn()
    {
        SceneManager.LoadScene("AsteroidGameWithAsteroids");


    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");


    }

}
