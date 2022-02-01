using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class endlessFinalScore : MonoBehaviour
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
        if (Countdown.henry == false)
        {
            text.text = "Final Score: " + Endless.rounds.ToString("0");
        }
    }
}
