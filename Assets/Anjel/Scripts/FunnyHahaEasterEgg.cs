using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FunnyHahaEasterEgg : MonoBehaviour
{
    public GameObject funnyfilter;
    public AudioSource regularmusic;
    public AudioSource funnymusic;
    public Text funnytext;
    bool USA = false;
    bool neveragain = false;

    private void Start()
    {


        if (SceneManager.GetActiveScene().name == "fireeeee" || SceneManager.GetActiveScene().name == "endlessfire")
        {
            if (Countdown.henry == true)
            {
                funnytext = GameObject.Find("gameoversub").GetComponent<Text>();
                funnymusic.Play();
                if (SceneManager.GetActiveScene().name == "fireeeee")
                {
                    funnytext.text = "The beans burnt and caused a fire...\n Audio from FNAF 6";
                }
                if (SceneManager.GetActiveScene().name == "endlessfire")
                {
                    funnytext.text = "Final Score: " + Endless.rounds.ToString("0") + "\n Audio from FNAF 6";
                }
            }
            else
            {
                regularmusic.Play();
            }
        }

        if (SceneManager.GetActiveScene().name == "testscene" || SceneManager.GetActiveScene().name == "endless")
        {

        }
    }

    // Start is called before the first frame update
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "testscene" || SceneManager.GetActiveScene().name == "endless")
        {
            if (Input.GetKey(KeyCode.U) && Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.A) && (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) && neveragain == false)
            {
                funnyfilter.gameObject.SetActive(true);
                Debug.Log("USA!!");
                USA = true;
            }

            if (USA == true)
            {
                USA = false;
                regularmusic.Stop();
                funnymusic.Play();
                neveragain = true;
            }
        }
    }
}
