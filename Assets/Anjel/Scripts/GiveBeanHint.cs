using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GiveBeanHint : MonoBehaviour
{
    GameObject helpUI;
    GameObject abuela;

    // Start is called before the first frame update
    void Start()
    {
        helpUI = GameObject.Find("PotLabel2");
        abuela = GameObject.Find("abuela");
        helpUI.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (SceneManager.GetActiveScene().name == "testscene")
        {
            if (abuela.gameObject.GetComponent<toyGeneration>().changeUI == true && abuela.gameObject.GetComponent<BeanCollect2>().count > 0)
            {
                helpUI.gameObject.SetActive(true);
            }
            else
            {
                helpUI.gameObject.SetActive(false);
            }
        }

        if (SceneManager.GetActiveScene().name == "endless")
        {
            if (abuela.gameObject.GetComponent<endlessToyGen>().changeUI == true && abuela.gameObject.GetComponent<BeanCollect2>().count > 0)
            {
                helpUI.gameObject.SetActive(true);
            }
            else
            {
                helpUI.gameObject.SetActive(false);
            }
        }
    }
}
