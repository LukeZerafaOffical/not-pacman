using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PointGUI : MonoBehaviour
{
    int pointStored = 0;
    [SerializeField]
    TextMeshProUGUI textUI;
    

    internal void IncreasePoints(int value)
    {
        pointStored += value;
        textUI.text = pointStored.ToString("D3");
    }
}
