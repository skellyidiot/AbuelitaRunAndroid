using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Unlocked"))
        {
            Unlock.unlockendless = PlayerPrefs.GetInt("Unlocked") == 1 ? true : false;
        }

        if (Unlock.unlockendless)
        {
            SceneManager.LoadScene("TitleSceneWithUnlock");
            return;
        }
        SceneManager.LoadScene("TitleScene");
    }
}
