using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public Animator a;

    Vector2 movement;
    public bool canMove = true;

    private void Start()
    {
        a = gameObject.GetComponent<Animator>();
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        //credit + dev shortcuts :D
        if(Input.GetKeyDown(KeyCode.C)) 
        {
            SceneManager.LoadScene("CreditScene");
        }

        if (Input.GetKeyDown(KeyCode.Alpha0) && Input.GetKey(KeyCode.LeftShift))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Unlock.unlockendless == false)
            {
                SceneManager.LoadScene("TitleScene");
            }
            else
            {
                SceneManager.LoadScene("TitleSceneWithUnlock");
            }
        }


        if (a.GetBool("death") == false && canMove == true)
        {
            //movement.x = Input.GetAxisRaw("Horizontal");
            //movement.y = Input.GetAxisRaw("Vertical");

            movement.x = SimpleInput.GetAxisRaw("Horizontal");
            movement.y = SimpleInput.GetAxisRaw("Vertical");

            a.SetFloat("Horizontal", movement.x);
            a.SetFloat("Vertical", movement.y);
            a.SetFloat("speed", movement.sqrMagnitude);

            if(a.GetFloat("Horizontal") >= 0.5)
            {
                sr.flipX = true;
            }
            if(a.GetFloat("Horizontal") <= -0.5)
            {
                sr.flipX = false;
            }
            
        }

        if (a.GetBool("death") == true || canMove == false)
        {
            if (movement.x > 0.01)
            {
                sr.flipX = true;
            }

            if (movement.x < -0.01)
            {
                sr.flipX = false;
            }

            movement.x = 0;
            movement.y = 0;
        }
    }


    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

}
