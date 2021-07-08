using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LeaveTimer : MonoBehaviour
{
    


    public Text timerText = null;
    float countDownTime = 10f;

    bool isInPlayArea = true;

    private void Start()
    {
        timerText.text = "";
    }
    private void Update()
    {
        if (!isInPlayArea)
        {
            
            
                countDownTime -= Time.deltaTime;
                timerText.text = $"You Have Left The Play Area \n {countDownTime.ToString("0.00")}";
            
            if (countDownTime <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("GameController"))
        {
            //timerText.gameObject.SetActive(true);
            isInPlayArea = false;
            
        }
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GameController"))
        {
            //timerText.gameObject.SetActive(false);
            isInPlayArea = true;
            timerText.text = "";
            
            countDownTime = 10f;
        }
        
    }

    public float Timer(float startTime)
    {
        return 0f;
    }
}
