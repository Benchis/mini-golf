using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gameplay : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D body;
    Vector3 mousePos;
    Vector3 mousePos2;
    float frictionFactor = 0.2f;
    bool heldDown = false;

    void Start()
    {
        body = gameObject.GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (body.velocity.x < 0.03f && body.velocity.y < 0.03f && body.velocity!=Vector2.zero)
        {
            body.velocity = Vector2.zero;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (body.velocity == Vector2.zero)
            {
                mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                heldDown = true;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            mousePos2 = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (heldDown)
            {
                body.AddForce(new Vector2(x: -(mousePos2.x - mousePos.x), y: -(mousePos2.y - mousePos.y))*30);
                heldDown = false;
            }
        }
        if (body.velocity!=Vector2.zero)
        {
            body.velocity = new Vector2(body.velocity.x-body.velocity.x * frictionFactor * Time.deltaTime, body.velocity.y-body.velocity.y *frictionFactor* Time.deltaTime);
        }
    }
    
}
