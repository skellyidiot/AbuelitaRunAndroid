using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class DogStun : MonoBehaviour
{
    public GameObject target;
    public GameObject point;

    Animator anim;

    public float gritoTimer = 2;
    public bool toggleTimer = false;

    Rigidbody2D rb2;

    Rigidbody2D rb22;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = target.gameObject.GetComponent<Rigidbody2D>();
        rb22 = this.gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(rb22.position, rb2.position);
        if (dist <= 3.5f && target.gameObject.GetComponent<Grito>().grito == true)
        {
            toggleTimer = true;
        }

        if (toggleTimer == true && gritoTimer > 0)
        {
            point.gameObject.GetComponent<DogAI>().canMove = false;
            gritoTimer -= Time.deltaTime;
            anim.SetBool("scared", true);
        } 

        if (gritoTimer <= 0)
        {
            toggleTimer = false;
            gritoTimer = 2;
            point.gameObject.GetComponent<DogAI>().canMove = true;
            anim.SetBool("scared", false);
        }
    }
}
