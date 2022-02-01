using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float time = 0;
    public Text Text;

    GameObject bean;
    GameObject abuela;

    private void Start()
    {
        Text = gameObject.GetComponent<Text>();
        abuela = GameObject.Find("abuela");
        bean = GameObject.Find("BeanDetect");
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (bean.gameObject.GetComponent<Countdown>().firstTime == true)
        {
            time += Time.deltaTime;
            Text.text = time.ToString("0.00") + "\n" + abuela.gameObject.GetComponent<GameplayLoop>().displayrounds + "/2 Servings";
        }
    }
}
