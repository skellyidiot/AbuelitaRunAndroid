using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollScript : MonoBehaviour
{
    // Add this script to the moveable object
    public RectTransform rectTransform;
    Vector3 offset;
    public void GetOffset()
    {
        offset = rectTransform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    public void MoveObject()
    {
        rectTransform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        rectTransform.position = new Vector3(0, rectTransform.position.y, 0);
    }
}
