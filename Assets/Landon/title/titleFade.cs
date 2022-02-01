using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;

public class titleFade : MonoBehaviour
{
    public Animator a;
    bool click = false;

    public GameObject image;
    float fades = 1;

    // Start is called before the first frame update
    void Start()
    {
        image.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (click == true)
        {
            fades -= Time.deltaTime;
        }

        if (fades <= 0)
        {
            SceneManager.LoadScene("testScene");
        }
    }

    public void fadeOut()
    {
        click = true;
        image.gameObject.SetActive(true);
    }
}
