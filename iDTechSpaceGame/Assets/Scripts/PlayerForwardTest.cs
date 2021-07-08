using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForwardTest : MonoBehaviour
{
    // Start is called before the first frame update

    bool passed = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (transform.position.z >= 900)
        {
            passed = true;
        }
        if (passed)
        {
            transform.Translate(Vector3.back);
        }
        else
        {
            transform.Translate(Vector3.forward * 10f);
        }
        
    }
}
