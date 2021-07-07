using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCounter : MonoBehaviour
{
    Text text;
    private void Start()
    {
        text = GetComponent<Text>();
        AmmoUpdate(29);
    }
    public void AmmoUpdate(float bulletCount)
    {
        text.text = bulletCount.ToString() + "/40";
    }
}
