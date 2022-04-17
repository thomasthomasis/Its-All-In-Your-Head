using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() 
    { 
    
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, 0);

        transform.position += (Movement * speed * Time.deltaTime);
    }
}
