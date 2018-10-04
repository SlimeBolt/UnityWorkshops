using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour
{

    public int attackDamage = 10;               // The amount of health taken away per attack.



    GameObject player;                          // Reference to the player GameObject.
    PlayerHealth playerHealth;                  // Reference to the player's health.

    bool playerInRange;                         // Whether player is within the trigger collider and can be attacked.



    void Awake()
    {
        // Setting up the references.
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();


    }


    void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        if (other.gameObject == player)
        {
            if (playerHealth.currentHealth > 0)
            {
                // ... damage the player.
                playerHealth.TakeDamage(attackDamage);
            }
        }
    }

}
    