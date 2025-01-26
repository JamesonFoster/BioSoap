using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jermany : MonoBehaviour

{
    public GameObject player; // Assign the player's transform in the Inspector
    public float speed = 5f; // Speed at which the object will follow the player
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        if (player != null)
        {
            // Calculate the direction to the player
            Vector3 direction = player.transform.position - transform.position;
            direction.Normalize();

            // Move the object towards the player
            transform.position += direction * speed * Time.deltaTime;

            // Rotate the object to face the player
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);
        }
    }
}