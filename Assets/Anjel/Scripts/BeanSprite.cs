using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BeanSprite : MonoBehaviour
{
    public GameObject burn;
    Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        ani = gameObject.GetComponent<Animator>();
        

        float countdown = burn.GetComponent<Countdown>().Counter;

        Debug.Log(countdown);
    }

    // Update is called once per frame
    void Update()
    {
        float count = burn.GetComponent<Countdown>().Counter;

        if (count >= 30f)
        {
            Debug.Log("bean1");
            ani.Play("realBean");
        }

        if (count < 30 && count >= 20)
        {
            Debug.Log("bean2");
            ani.Play("realbean2");
        }

        if (count < 20 && count >= 10)
        {
            ani.Play("realBean3");
        }

        if (count < 10 && count > 0)
        {
            ani.Play("realBean4");
        }

        if (count <= 0)
        {
            ani.Play("realBean5");
        }
    }
}
