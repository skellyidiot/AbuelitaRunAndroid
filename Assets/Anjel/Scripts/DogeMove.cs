using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DogeMove : MonoBehaviour
{
    SpriteRenderer sr;
    Animator a;
    Rigidbody2D rb2;

    Vector2 movement;

    public GameObject poimter;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = poimter.gameObject.GetComponent<Rigidbody2D>();
        sr = gameObject.GetComponent<SpriteRenderer>();
        a = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = rb2.velocity.x;
        movement.y = rb2.velocity.y;

        a.SetFloat("Horizontal", movement.x);
        a.SetFloat("Vertical", movement.y);

        if (movement.x < -0.01)
        {
            sr.flipX = true;
        }
        if (movement.x > 0.01)
        {
            sr.flipX = false;
        }
    }
}
