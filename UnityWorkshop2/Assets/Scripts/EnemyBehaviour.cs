using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour {

    private Transform player;
    public float rotSpeed, moveSpeed;
    private float distance;
    public float maxDistance; // the maximum distance the enemy will be able to "lock onto" the player from.

    private State CurrentState;

    enum State { Following, Standing };

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        CurrentState = State.Standing;
    }

    void Update()
    {
        if (Vector3.Distance(player.transform.position, transform.position) <= maxDistance)
        {
            CurrentState = State.Following;
        }
        else
        {
            CurrentState = State.Standing;
        }

        switch (CurrentState) {
            case State.Following : FollowPlayer(); break;
        }
    }

    void FollowPlayer()
    {
        // Rotate / Look at player
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), rotSpeed * Time.deltaTime);

        // Move torwards player
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
    }
}
