using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class KitchenZOOM : MonoBehaviour
{
    public GameObject abuela;
    public GameObject kitch;
    public GameObject dine;
    public CinemachineVirtualCamera cm;
    public CinemachineVirtualCamera cm2;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "KitchenDetect")
        {
            cm.m_Priority = 1;
        }

        if (collision.gameObject.name == "DiningDetect")
        {
            cm2.m_Priority = 420;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "KitchenDetect")
        {
            cm.m_Priority = 69;
        }

        if (collision.gameObject.name == "DiningDetect")
        {
            cm2.m_Priority = 0;
        }
    }
}
