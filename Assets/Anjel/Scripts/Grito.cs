using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Grito : MonoBehaviour
{
    public bool grito = false;
    public float gritoCooldown = 0;
    public float gritoDuring = 0.75f;
    public bool dead = false;

    public AudioSource scream;
    public Animator a;

    GameObject bean;
    GameObject UI;
    GameObject UI2;
    GameObject UI3;

    public GameObject GritoUI;

    // Start is called before the first frame update
    void Start()
    {
        bean = GameObject.Find("BeanDetect");
        UI = GameObject.Find("Grito");
        UI2 = GameObject.Find("GritoLabel");
        UI3 = GameObject.Find("PotLabel");
    }

    // Update is called once per frame
    void Update()
    {
        if (gritoCooldown <= 0 && GritoUI.gameObject.GetComponent<gritoTouch>().touched == true && bean.gameObject.GetComponent<Countdown>().inZone == false && gameObject.GetComponent<Healp>().health > 0)
        {
            scream.Play();
            grito = true;
            UI.SetActive(false);
            UI2.SetActive(false);
            GritoUI.gameObject.GetComponent<gritoTouch>().touched = false;
        }

        if (grito == true && gritoDuring > 0)
        {
            gritoDuring -= Time.deltaTime;
            gameObject.GetComponent<PlayerMovement>().canMove = false;
            a.SetBool("grito", true);
        }

        if (grito == true && gritoDuring <= 0)
        {
            grito = false;
            gameObject.GetComponent<PlayerMovement>().canMove = true;
            gritoCooldown = 5;
            a.SetBool("grito", false);
        }
        
        if (gritoCooldown > 0)
        {
            gritoCooldown -= Time.deltaTime;
            gritoDuring = 0.75f;
        }

        if (gritoCooldown <= 0 && gritoDuring == 0.75f && bean.gameObject.GetComponent<Countdown>().inZone == false)
        {
            UI.SetActive(true);
            UI2.SetActive(true);
        }

        if (bean.gameObject.GetComponent<Countdown>().inZone == true)
        {
            UI2.gameObject.SetActive(false);
            UI3.gameObject.SetActive(true);
        }

        if (bean.gameObject.GetComponent<Countdown>().inZone == false || Input.GetKey(KeyCode.O))
        {
            UI3.gameObject.SetActive(false);
        }
    }
}
