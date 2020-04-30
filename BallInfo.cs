using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInfo : MonoBehaviour
{
    public static BallInfo instance;
    public int num;
    private Color color;

    private void Start()
    {
        instance = this;
        this.name = num.ToString();
    }
}
