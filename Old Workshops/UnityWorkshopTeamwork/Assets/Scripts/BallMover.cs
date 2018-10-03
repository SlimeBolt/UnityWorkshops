using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallMover : MonoBehaviour {

    // Use this for initialization
    public float speed = 10.0f;

    public Text timer;

    private int counter = 0;

    private bool isGrounded = true;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
    }

    void FixedUpdate()
    {
        counter++;
        timer.text = "Time: " + counter;

        float moveVertical  = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(moveVertical, 0.0f, moveHorizontal);

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
