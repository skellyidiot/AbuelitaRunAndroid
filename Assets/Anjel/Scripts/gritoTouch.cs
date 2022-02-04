using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class gritoTouch : MonoBehaviour
{
    public bool touched = false;
    //public Button button;

    // Start is called before the first frame update
    void Start()
    {
        //Button btn = button.GetComponent<Button>();
        //btn.onClick.AddListener(Down);
    }

    // Update is called once per frame
    void Update()
    {
        //Button btn = button.GetComponent<Button>();

        //if (btn.onClick == false)
        {
            //touched = false;
        }
    }

    public void OnMouseDown(MouseDownEvent a)
    {
        Debug.Log("HHHHHH");
        touched = true;
    }

    public void OnMouseUp(MouseUpEvent e)
    {
        touched = false;
    }
}
