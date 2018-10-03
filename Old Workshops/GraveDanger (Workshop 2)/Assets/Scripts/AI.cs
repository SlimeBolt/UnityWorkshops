using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Please make sure to either name the script "FollowPlayer_AI" or change that text next
// to public class \/ to the name of your script.
public class AI : MonoBehaviour
{

    private Transform player;
    public float rotSpeed, moveSpeed;
    private float distance;
    public float maxDistance; // the maximum distance the enemy will be able to "lock onto" the player from.


    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    void Update()
    {
        if (Vector3.Distance(player.transform.position, gameObject.transform.position) <= maxDistance)
        {
            FollowPlayer();
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