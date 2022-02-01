using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class Healp : MonoBehaviour
{
    SpriteRenderer sr;
    Animator a;
    Collider2D coll;

    public int health;
    public float i;
    public float respawncount = 3;

    public float fades = 2;

    public Animator fade;

    public bool canHurt = true;

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        a = gameObject.GetComponent<Animator>();
        coll = gameObject.GetComponent<CapsuleCollider2D>();

        health = 2;

        fade.Play("fadeIn");
    }

    private void Update()
    {

        Color c = sr.color;
        c.a = 0.75f;

        

        if (health == 1)
        {
            sr.color = c;
            canHurt = false;
            if (i > 0.01)
            {
                i -= Time.deltaTime;
            }
            if (i < 0.01)
            {
                c.a = 1;
                sr.color = c;
                canHurt = true;
            }
        }
        if (health <= 0)
        {
            fades -= Time.deltaTime;

            a.SetBool("death", true);
            a.SetBool("bean", false);
            respawncount -= Time.deltaTime;

            fade.Play("endFade");

            if (fades <= 0)
            {
                if (SceneManager.GetActiveScene().name == "endless")
                {
                    SceneManager.LoadScene("endlessdead");
                }
                else
                {
                    SceneManager.LoadScene("deadEnding");
                }
            }
        }

        if (respawncount <= 0)
        {
            if (SceneManager.GetActiveScene().name == "endless")
            {
                SceneManager.LoadScene("endless");
            } else
            {
                SceneManager.LoadScene("testscene");
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.tag == "Spawnable" || collision.gameObject.tag == "Spawnable2"  || collision.gameObject.tag == "doge") && canHurt == true)
        {
            health--;
           
            if (collision.gameObject.tag == "Spawnable")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
