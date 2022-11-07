using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * speed, ForceMode2D.Impulse);
        }

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.right * -speed, ForceMode2D.Impulse);
        }
    }
}
