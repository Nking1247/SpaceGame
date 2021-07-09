using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    public Image healthbarwidth;
    


    


    public void HealthChange(float health)
    {
        
        
        healthbarwidth.fillAmount = health/5;
        
    }
}
