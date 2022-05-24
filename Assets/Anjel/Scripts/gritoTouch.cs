using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class gritoTouch : MonoBehaviour
{
    public bool touched = false;
    //public Button button;

    // Start is called before the first frame update
    void Start()
    {
    }

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
            Debug.LogError(hitInfo.collider.name);

            if (hitInfo.collider.tag == "GritoUI")
            {
                touched = true;
            } else
            {
                touched = false;
            }
        }
    }
}
