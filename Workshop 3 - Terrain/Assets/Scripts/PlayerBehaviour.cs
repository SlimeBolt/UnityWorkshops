using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    CharacterController characterController;
    private InventoryBehaviour inventory;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        inventory = GetComponent<InventoryBehaviour>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes


            float v = Input.GetAxis("Vertical");
            float h = Input.GetAxis("Horizontal");

            Vector3 targetDirection = new Vector3(h, 0f, v);
            targetDirection = GetComponent<Camera>().transform.TransformDirection(targetDirection);
            targetDirection.y = 0.0f;

            moveDirection = targetDirection * speed;

            //moveDirection += transform.forward * v * speed * Time.deltaTime;
            //moveDirection += transform.right * h * speed * Time.deltaTime;

            //moveDirection = , 0.0f, );
            // moveDirection *= speed;
            // moveDirection = transform.TransformDirection(Vector3.forward) * speed;


            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;
        // moveDirection = transform.TransformDirection(moveDirection);
        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
    }

    // Use this for initialization
    public InventoryBehaviour GetInventory()
    {
        return inventory;
    }

}
