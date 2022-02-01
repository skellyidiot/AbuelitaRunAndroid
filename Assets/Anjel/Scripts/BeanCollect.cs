using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanCollect : MonoBehaviour
{
    public GameObject bean;
    public bool carry = false;
    public bool inZone = false;

   

    void Update()
    {
        if(inZone == true && Input.GetKeyDown(KeyCode.P))
        {
            carry = true;
            Debug.Log("BEAN");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "BeanDetect")
        {
            inZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "BeanDetect")
        {
            inZone = false;
        }
    }
}
