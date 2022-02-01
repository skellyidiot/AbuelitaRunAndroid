using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotate : MonoBehaviour
{
    SpriteRenderer sr;
    Rigidbody2D rb2;

    // Start is called before the first frame update
    void Start()
    {
        sr = gameObject.GetComponent<SpriteRenderer>();
        rb2 = gameObject.GetComponent<Rigidbody2D>();

        //Debug.Log("fuckyou");
    }

    // Update is called once per frame
    void Update()
    {
        float horizValue = rb2.velocity.x;
        //Debug.Log(horizValue);

        if (horizValue < -0.1)
        {
            transform.Rotate(0f, 0f, transform.rotation.z + horizValue/4);
        }
        if (horizValue > 0.1)
        {
            transform.Rotate(0f, 0f, transform.rotation.z - horizValue/4);
        }
    }
}
