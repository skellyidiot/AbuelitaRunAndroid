using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToyDelete : MonoBehaviour
{
    //public GameObject spawn;

    // Start is called before the first frame update
    void Start()
    {
        //spawn = GameObject.FindGameObjectsWithTag("Spawnable");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
         //Debug.Log("huthsut");
       if(collision.gameObject.tag == "Spawnable")
        {
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Spawnable2")
        {
            Destroy(collision.gameObject);
        }

        gameObject.SetActive(false);
    }
  
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
