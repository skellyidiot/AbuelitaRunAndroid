using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeanTouch : MonoBehaviour
{
    public bool touched;
    public bool held;
    float holdtime;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hitInfo = new RaycastHit2D();
            int layer_mask = LayerMask.GetMask("UI Interact");
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);
            hitInfo = Physics2D.Raycast(mousePos2D, Vector2.zero, 100000, layer_mask);

            if (hitInfo.collider.tag == "BeansUI")
            {
                touched = true;
            }
            else
            {
                touched = false;
            }
        }

        if (touched == true && holdtime <= 0.5f)
        {
            holdtime += Time.deltaTime;
        }

        if (holdtime >= 0.5f)
        {
            held = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            holdtime = 0;
            touched = false;
            held = false;
        }
    }
}
