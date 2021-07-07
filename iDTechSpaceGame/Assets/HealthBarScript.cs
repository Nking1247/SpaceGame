using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{
    RectTransform healthbarwidth;
    public Transform Background;

    private void Start()
    {
        healthbarwidth = GetComponent<RectTransform>();

    }

    public void HealthChange(float health)
    {
        
        healthbarwidth.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, health);
        print(healthbarwidth.offsetMin.x);
        healthbarwidth.position = Background.position + new Vector3(healthbarwidth.offsetMax.x/2,0,0);
    }
}
