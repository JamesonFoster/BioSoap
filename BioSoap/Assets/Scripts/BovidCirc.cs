using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BovidCirc : MonoBehaviour
{
    float timeCounter = 0;
    public float agroTimer = 30;
    float checker = 0;
    public float speed = 2;
    public float changes = 0;
    public GameObject player;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }


    void Update()
    {
        if (checker <= agroTimer)
        {
            timeCounter += Time.deltaTime;
            float x = Mathf.Sin(timeCounter);
            float y = 10;
            float z = Mathf.Sin(timeCounter);
            transform.position = new Vector3(x, y, z);
            checker += Time.deltaTime;
        }
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
