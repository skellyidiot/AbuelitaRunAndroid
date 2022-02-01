using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text text;


    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Timer.time);
       text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Final Time: " + Timer.time.ToString("0.00");
    }
}
