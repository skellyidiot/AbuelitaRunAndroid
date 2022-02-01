using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonscripts : MonoBehaviour
{
    private void Start()
    {
        Screen.SetResolution(1024, 768, Screen.fullScreen);
        if(Application.platform == RuntimePlatform.Android)
        {
            Screen.SetResolution(3120, 1440, Screen.fullScreen);
        }

        Debug.Log("Change resolution");
    }
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Exited");
    }

    public void StartButton()
    {
        SceneManager.LoadScene("testscene");
    }

    public void EndlessButton()
    {
        SceneManager.LoadScene("endless");
    }

    public void CreditsButton()
    {
        SceneManager.LoadScene("CreditScene");
    }

    public void ReturnButton()
    {
        if (Unlock.unlockendless == false)
        {
            SceneManager.LoadScene("TitleScene");
        }
        else
        {
            SceneManager.LoadScene("TitleSceneWithUnlock");
        }
    }
}
