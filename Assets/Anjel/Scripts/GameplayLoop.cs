using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class GameplayLoop : MonoBehaviour
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
    public int rounds;
    public int displayrounds;
    bool reset = false;

    public Animator fade;
    float fades = 1.25f;

    // Start is called before the first frame update
    void Start()
    {
        
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

        if (c1 == true && c2 == true && c3 == true && c4 == true && c5 == true && c6 == true && rounds == 0 && displayrounds == 0)
        {
            reset = true;
            displayrounds += 1;
        }

        if (reset == true && beanzone.gameObject.GetComponent<Countdown>().inZone == true)
        {
            reset = false;
            rounds += 1;
            child1.gameObject.GetComponent<hasBean>().eatingBean = false;
            child2.gameObject.GetComponent<hasBean>().eatingBean = false;
            child3.gameObject.GetComponent<hasBean>().eatingBean = false;
            child4.gameObject.GetComponent<hasBean>().eatingBean = false;
            child5.gameObject.GetComponent<hasBean>().eatingBean = false;
            child6.gameObject.GetComponent<hasBean>().eatingBean = false;
        }

        if (c1 == true && c2 == true && c3 == true && c4 == true && c5 == true && c6 == true && rounds == 1 && beanzone.gameObject.GetComponent<Countdown>().inZone == false)
        {

            displayrounds = 2;

            fades -= Time.deltaTime;

            fade.Play("goodFade");

            if (fades <= 0)
            {
                SceneManager.LoadScene("goodEnding");
            }
        }
    }
}
