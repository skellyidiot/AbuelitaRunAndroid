using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAway : MonoBehaviour
{
    public GameObject target;

    Rigidbody2D rb2;

    Rigidbody2D rb22;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = target.gameObject.GetComponent<Rigidbody2D>();
        rb22 = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = (Vector3.Distance(rb22.position,rb2.position) * -1) + 4;
        //Debug.Log("Distance is " + speed);

        if (target.gameObject.GetComponent<Grito>().grito == true && speed > 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, rb2.position, -4 * speed * Time.deltaTime);
        }
    }
}
