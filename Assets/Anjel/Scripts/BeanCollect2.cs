using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class BeanCollect2 : MonoBehaviour
{
    public GameObject bean;
    public int count = 0;
    public bool inZone = false;
    public GameObject abuelita;
    SpriteRenderer sr;
    public bool canBean = false;

    Animator anim;

    public BeanTouch touch;

    private void Start()
    {
        sr = abuelita.GetComponent<SpriteRenderer>();
        anim = abuelita.GetComponent<Animator>();
    }

    void Update()
    {

        if(inZone == true && touch.touched && sr.flipX == true)
        {
            count = 4;
            Debug.Log("BEAN");
        }

        if (count > 0)
        {
            anim.SetBool("bean", true);
        }
        else
        {
            anim.SetBool("bean", false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "BeanDetect")
        {
            inZone = true;
        }

        if (collision.tag == "kids")
        {
            canBean = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "BeanDetect")
        {
            inZone = false;
        }

        if (collision.tag == "kids")
        {
            canBean = false;
        }
    }
}
