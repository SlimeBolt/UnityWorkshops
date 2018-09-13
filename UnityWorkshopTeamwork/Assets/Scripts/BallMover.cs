using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour {

    // Use this for initialization
    public float speed = 5.0f;

    private bool isGrounded = true;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Vertical");
        float moveVertical = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical) * 5;

        rb.AddForce(movement * speed);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(new Vector3(0, 3, 0), ForceMode.Impulse);
        }
    }

    void OnCollisionEnter()
    {
        isGrounded = true;
    }
}
