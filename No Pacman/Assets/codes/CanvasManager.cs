using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public static CanvasManager CanvasUI;
    
    [SerializeField]
    PointGUI points;
    void Awake()
    {
        CanvasUI = this;
    }
    public void IncreasePoints(int value)
    {
        points.IncreasePoints(value);
    }
}
