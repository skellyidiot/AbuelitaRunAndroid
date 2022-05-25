using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock : MonoBehaviour
{
    public static bool unlockendless;

    // Start is called before the first frame update
    void Start()
    {
        unlockendless = true;
        PlayerPrefs.SetInt("Unlocked", (unlockendless ? 1 : 0));
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
