using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    float xmot;
    float ymot;
    private void Update()
    {
        ymot = Input.GetAxis("Vertical");
        xmot = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(xmot, ymot) * Time.deltaTime * speed);
    }
}
