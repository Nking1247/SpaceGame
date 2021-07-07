using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PortalPieceScript : MonoBehaviour
{
    Text text;

    private void Start()
    {
        text = GetComponent<Text>();
    }
    public void PieceCount(int pieceCount)
    {
        text.text = pieceCount.ToString() + "/10";
    }
}
