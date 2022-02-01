using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GritoMask : MonoBehaviour
{
    public void MoveMask(int currentValue, int maxValue)
    {
        float percentToMove = (float)currentValue / (float)maxValue;
        transform.localPosition = new Vector3(percentToMove - 1, 0, 0);
    }
}
