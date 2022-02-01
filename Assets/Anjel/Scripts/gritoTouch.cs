using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gritoTouch : MonoBehaviour
{
    public bool touched = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        touched = true;
    }

    private void OnMouseUp()
    {
        touched = false;
    }
}
