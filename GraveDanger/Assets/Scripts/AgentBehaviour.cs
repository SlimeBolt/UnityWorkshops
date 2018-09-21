using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentBehaviour : MonoBehaviour
{

    NavMeshAgent agent;

    public PlayerHealth playerHealth;
    public bool keycard1;
    public bool keycard2;

    private bool immortal = false;
    private float immortalTime;
    public int immortalDuration;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        playerHealth.Reset();
        keycard1 = false;
        keycard2 = false;
    }

    private void FixedUpdate()
    {
        if (immortal && immortalTime + immortalDuration < Time.time)
        {
            immortal = false;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                agent.destination = hit.point;
            }
        }
        playerHealth.UpdateHealth();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Danger") && immortal != true)
        {
            playerHealth.TakeDamage(5);
            immortal = true;
            immortalTime = Time.time;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("KeyCard1"))
        {
            keycard1 = true;
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("KeyCard2"))
        {
            keycard2 = true;
            Destroy(other.gameObject);
        }
        
    }
}