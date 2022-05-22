using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    private float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        variables = GetComponent<Variables>();

        jumpForce = variables.jumpForce;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
