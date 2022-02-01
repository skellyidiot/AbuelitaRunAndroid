using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDog : MonoBehaviour
{
    public GameObject pointer;
    private Rigidbody2D rb2;
    private Vector3 pos;

    // Update is called once per frame
    void Update()
    {
        //rb2.MovePosition(pointer.transform.position);
        pos = pointer.transform.position;
        transform.position = pos;
    }
}
