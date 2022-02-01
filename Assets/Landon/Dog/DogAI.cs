using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAI : MonoBehaviour
{

    //Make sure to have objects named "point0", "point1", "point2", and "point3"!!

    private Rigidbody2D rb2;
    public GameObject target;
    public float speed;
    public float movescale;
    public GameObject Point0;
    public GameObject Point1;
    public GameObject Point2;
    public GameObject Point3;
    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        target = GameObject.Find("point0");
        Point0 = GameObject.Find("point0");
        Point1 = GameObject.Find("point1");
        Point2 = GameObject.Find("point2");
        Point3 = GameObject.Find("point3");
    }

    // Update is called once per frame
    void Update()
    {
        //point at player
        Vector3 vectorToTarget = target.transform.position - transform.position;
        float angle = Mathf.Atan2(vectorToTarget.y, vectorToTarget.x) * Mathf.Rad2Deg - 90;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, Time.deltaTime * speed);

        //move

        if(canMove == true)
        {
            float move = Time.deltaTime * movescale;
            rb2.AddForce(transform.up * move);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "point0") {
            target = Point1;
        }
        if (collision.gameObject.name == "point1")
        {
            target = Point2;
        }
        if (collision.gameObject.name == "point2")
        {
            target = Point3;
        }
        if (collision.gameObject.name == "point3")
        {
            target = Point0;
        }
    }
}
