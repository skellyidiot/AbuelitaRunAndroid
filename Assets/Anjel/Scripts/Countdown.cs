using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class Countdown : MonoBehaviour
{

    public float Counter = 40;
    public bool inZone = false;
    public bool firstTime = false;
    public Healp heal;
    public static bool henry = false;

    public AudioSource stir;
    float fades = 2;
    public Animator fade;

    public GameObject abuelita;
    public GameObject stirUI;

    public Text txtBeanCount;

    public BeanTouch touch;

    private void Start()
    {
        abuelita = GameObject.Find("abuela");
        stirUI = GameObject.Find("PotLabel3");
        henry = false;
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey(KeyCode.H) && Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.N) && Input.GetKey(KeyCode.R) && Input.GetKey(KeyCode.Y))
        {
            henry = true;
        }
        else
        {
            henry = false;
        }


        if (Counter > 0 && (firstTime == true))
        {
            Counter -= Time.deltaTime;
        }

        if (touch.held && (inZone == true) && Counter > 0 && abuelita.gameObject.GetComponent<SpriteRenderer>().flipX == true)
        {
            if (Counter < 40f)
            {
                Counter += Time.deltaTime * 8;
            }
            if (!stir.isPlaying) stir.Play();
            stirUI.gameObject.SetActive(true);
        }

        if (!touch.held || (inZone == false) || abuelita.gameObject.GetComponent<SpriteRenderer>().flipX == false)
        {
            stir.Stop();
            stirUI.gameObject.SetActive(false);
        }

        if (Counter <= 0)
        {
            //heal.health = 0;
            fades -= Time.deltaTime;

            fade.Play("firefadeOut");

            if (fades <= 0)
            {
                if (SceneManager.GetActiveScene().name == "endless")
                {
                    SceneManager.LoadScene("endlessfire");
                }
                else
                {
                    SceneManager.LoadScene("fireeeee");
                }
            }
        }

        txtBeanCount.text = Counter.ToString();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inZone = true;
            firstTime = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            inZone = false;
        }
    }

}
