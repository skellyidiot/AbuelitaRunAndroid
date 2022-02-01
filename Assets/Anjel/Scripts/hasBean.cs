using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hasBean : MonoBehaviour
{
    public Animator a;
    public bool eatingBean = false;
    GameObject abuela;
    Rigidbody2D abuelarb2;
    Rigidbody2D thisrb2;

    // Start is called before the first frame update
    void Start()
    {
        abuela = GameObject.Find("abuela");
        abuelarb2 = abuela.gameObject.GetComponent<Rigidbody2D>();
        thisrb2 = gameObject.GetComponent<Rigidbody2D>();
        a = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (abuela.gameObject.GetComponent<BeanCollect2>().canBean == true && Vector3.Distance(abuelarb2.position, thisrb2.position) <= 1.5 && Input.GetKeyDown(KeyCode.P) && abuela.gameObject.GetComponent<BeanCollect2>().count > 0 && eatingBean == false)
        {
            eatingBean = true;
            abuela.gameObject.GetComponent<BeanCollect2>().count -= 1;
            if (this.gameObject.name == "yelloKid")
            {
                a.Play("yelloEat");
            }
            if (this.gameObject.name == "nameConflictDetected")
            {
                a.Play("miniEat");
            }
            if (this.gameObject.name == "emo")
            {
                a.Play("emoEat");
            }
            if (this.gameObject.name == "marco")
            {
                a.Play("marcoEat");
            }
            if (this.gameObject.name == "5head")
            {
                a.Play("5headEat");
            }
            if (this.gameObject.name == "isthisaboyoragirl")
            {
                a.Play("yuhEat");
            }

        }

        if (abuela.gameObject.GetComponent<BeanCollect2>().canBean == true && Vector3.Distance(abuelarb2.position, thisrb2.position) <= 1.5 && abuela.gameObject.GetComponent<BeanCollect2>().count > 0 && eatingBean == false)
        {

            if (this.gameObject.name == "yelloKid")
            {
                a.Play("yelloGlow");
            }
            if (this.gameObject.name == "nameConflictDetected")
            {
                a.Play("miniGlow");
            }
            if (this.gameObject.name == "emo")
            {
                a.Play("emoGlow");
            }
            if (this.gameObject.name == "marco")
            {
                a.Play("marcoGlow");
            }
            if (this.gameObject.name == "5head")
            {
                a.Play("5headGlow");
            }
            if (this.gameObject.name == "isthisaboyoragirl")
            {
                a.Play("yuhGlow");
            }

        }
        else if (eatingBean == false)
        {
            if (this.gameObject.name == "yelloKid")
            {
                a.Play("yelloSit");
            }
            if (this.gameObject.name == "nameConflictDetected")
            {
                a.Play("miniSit");
            }
            if (this.gameObject.name == "emo")
            {
                a.Play("emoSit");
            }
            if (this.gameObject.name == "marco")
            {
                a.Play("marcoSit");
            }
            if (this.gameObject.name == "5head")
            {
                a.Play("5headSit");
            }
            if (this.gameObject.name == "isthisaboyoragirl")
            {
                a.Play("yuhSit");
            }
        }
    }
}
