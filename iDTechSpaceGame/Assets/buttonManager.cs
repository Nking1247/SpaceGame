using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("AsteroidGameWithAsteroids");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
