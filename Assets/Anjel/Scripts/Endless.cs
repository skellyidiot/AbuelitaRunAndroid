using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endless : MonoBehaviour
{
    public GameObject child1;
    public GameObject child2;
    public GameObject child3;
    public GameObject child4;
    public GameObject child5;
    public GameObject child6;
    public GameObject beanzone;
    public bool c1;
    public bool c2;
    public bool c3;
    public bool c4;
    public bool c5;
    public bool c6;
    public static int rounds;
    bool reset = false;
    bool reset2 = false;

    public Animator fade;
    float fades = 1.25f;

    // Start is called before the first frame update
    void Start()
    {
        rounds = 0;
    }

    // Update is called once per frame
    void Update()
    {
        c1 = child1.gameObject.GetComponent<hasBean>().eatingBean;
        c2 = child2.gameObject.GetComponent<hasBean>().eatingBean;
        c3 = child3.gameObject.GetComponent<hasBean>().eatingBean;
        c4 = child4.gameObject.GetComponent<hasBean>().eatingBean;
        c5 = child5.gameObject.GetComponent<hasBean>().eatingBean;
        c6 = child6.gameObject.GetComponent<hasBean>().eatingBean;

        if (c1 == true && c2 == true && c3 == true && c4 == true && c5 == true && c6 == true && reset2 == false)
        {
            reset = true;
        }

        if (reset == true)
        {
            reset = false;
            reset2 = true;
            rounds += 1;
        }

        if (reset2 == true && beanzone.gameObject.GetComponent<Countdown>().inZone == true)
        {
            reset2 = false;
            child1.gameObject.GetComponent<hasBean>().eatingBean = false;
            child2.gameObject.GetComponent<hasBean>().eatingBean = false;
            child3.gameObject.GetComponent<hasBean>().eatingBean = false;
            child4.gameObject.GetComponent<hasBean>().eatingBean = false;
            child5.gameObject.GetComponent<hasBean>().eatingBean = false;
            child6.gameObject.GetComponent<hasBean>().eatingBean = false;
        }
        
    }
}
