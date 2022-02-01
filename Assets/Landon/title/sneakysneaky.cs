using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sneakysneaky : MonoBehaviour
{
    Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            text.text = "(Try pressing SHIFT + H + E + N + R + Y when the beans burn!)";
        } else
        {
            text.text = "(Try pressing SHIFT + U + S + A to make the game like an American movie!)";
        }
    }
}
