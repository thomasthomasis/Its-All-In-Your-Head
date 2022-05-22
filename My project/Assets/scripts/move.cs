using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D rb;

    private Variables variables;

    private float speed;
    private float maxSpeed;

    private bool right = false;
    private bool left = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        variables = GetComponent<Variables>();

        speed = variables.speed;
        maxSpeed = variables.maxSpeed;
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            left = true;
        else
            left = false;

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            right = true;
        else
            right = false;

        if (rb.velocity.x > maxSpeed)
            rb.velocity = new Vector2(maxSpeed, rb.velocity.y);

        if (rb.velocity.x < -maxSpeed)
            rb.velocity = new Vector2(-maxSpeed, rb.velocity.y);

        Debug.Log(rb.velocity.x);
    }

    void FixedUpdate()
    {
        if(left)
            rb.AddForce(new Vector3(-1,0,0) * speed);

        if (right)
            rb.AddForce(new Vector3(1, 0, 0) * speed);
    }
}
