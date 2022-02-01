using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndlessScore : MonoBehaviour
{
    public Text Text;

    GameObject abuelita;

    // Update is called once per frame
    void Update()
    {
        Text.text = Endless.rounds.ToString("0") + " Servings";
    }
}
